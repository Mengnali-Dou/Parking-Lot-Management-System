using _2022_4C.data;
using _2022_4C.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C.lib.TemVehicle.FixVehicle
{
    public partial class form_OrderFormUpdate : Form
    {
        public form_OrderFormUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string licensePlateNum = txtNum.Text;
            string timeLength = numLength.Text;

            string select_Vehicle = $"select * from VEFixedVehicle where LicensePlateNum = '{licensePlateNum}'";
            OleDbDataAdapter inst1 = new OleDbDataAdapter(select_Vehicle, database.dbConn);
            DataTable dt1 = new DataTable();
            inst1.Fill(dt1);
            if (dt1.Rows.Count == 0)
            {
                DialogResult dialog = MessageBox.Show("无此车辆", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtNum.Focus();
                }
            }
            else
            {
                // 订单
                string date = DateTime.Now.ToShortDateString().ToString();
                string select_expireTime = $"select ExpireTime,PSSystemNum from OFFixedVehicle where LicensePlateNum = '{licensePlateNum}'";
                OleDbDataAdapter inst2 = new OleDbDataAdapter(select_expireTime, database.dbConn);
                DataTable dt2 = new DataTable();
                inst2.Fill(dt2);
                string expireTime = dt2.Rows[0][0].ToString();
                string parkingSpot = dt1.Rows[0][1].ToString();
                string newExpireTime = (DateTime.Parse(expireTime).AddMonths(Convert.ToInt32(timeLength))).ToShortDateString();

                string select_parkingArea = $"select PANum from PAParkingSpot where PSSystemNum = '{parkingSpot}'";
                OleDbDataAdapter inst3 = new OleDbDataAdapter(select_parkingArea, database.dbConn);
                DataTable dt3 = new DataTable();
                inst3.Fill(dt3);
                string parkingArea = dt3.Rows[0][0].ToString();
                string select_Park = $"select PSystemNum from PAParkingArea where PASystemNum = '{parkingArea}'";
                OleDbDataAdapter inst4 = new OleDbDataAdapter(select_parkingArea, database.dbConn);
                DataTable dt4 = new DataTable();
                inst4.Fill(dt4);
                string park = dt4.Rows[0][0].ToString();
                string OFFVNum = GenerateOFFVNum.OFFVNum(park);

                string insert_OFFVNum = $"insert into OFFixedVehicle (OFFVNum,LicensePlateNum,TopUpNum,TopUpDuration,ExpireTime,PSSystemNum,OFFVComment) values ('{OFFVNum}','{licensePlateNum}','{date}','{timeLength}','{newExpireTime}','{parkingSpot}','续费')";
                OleDbCommand cmd1 = new OleDbCommand(insert_OFFVNum, database.dbConn);
                cmd1.ExecuteNonQuery();

                // 收费单
                string chargeNum = GenerateChargeNum.ChargeNum(park);
                string select_cost = "select Cost from FIRates where RateNum = 'SX002'";
                OleDbDataAdapter inst5 = new OleDbDataAdapter(select_cost, database.dbConn);
                DataTable dt5 = new DataTable();
                inst5.Fill(dt5);
                string sum = (Convert.ToInt32(dt2.Rows[0][0]) * Convert.ToInt32(timeLength)).ToString();
                string insert_chargeNum = $"insert into FIVehicleCharge (ChargeNum,ChargeTime,Cost,OFNum,FIVCComment) values ('{chargeNum}','{date}','{sum}','{OFFVNum}','续费')";
                OleDbCommand cmd2 = new OleDbCommand(insert_chargeNum, database.dbConn);
                cmd2.ExecuteNonQuery();

            }

            database.dbConn.Close();
        }
    }
}
