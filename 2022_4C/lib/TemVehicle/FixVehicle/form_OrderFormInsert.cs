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
    public partial class form_OrderFormInsert : Form
    {
        public form_OrderFormInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string OwnerID = GenerateFVOwnerID.FVOwnerID();
            string sex = null;
            string name = txtOwnerName.Text;
            string tel = txtTel.Text;
            string date = DateTime.Now.ToShortDateString().ToString();
            string park = txtPark.Text;

            if (rbtnMale.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }

            // Owner
            string insert_Owner = $"insert into VOFixedVehicle (FVOwnerID,FVOwnerName,FVOwnerSex,FVOwnerTel,RegistrationTime) values ('{OwnerID}','{name}','{sex}','{tel}','{date}')";
            OleDbCommand cmd1 = new OleDbCommand(insert_Owner, database.dbConn);
            cmd1.ExecuteNonQuery();

            // OrderForm
            string OFFVNum = GenerateOFFVNum.OFFVNum(park);
            string licensePlateNum = txtNum.Text;
            string timeLength = numLength.ToString();
            string expireTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")).AddMonths(Convert.ToInt32(timeLength)).ToShortDateString();
            string parkSpot = txtParkSpot.Text;
            string insert_orderForm = $"insert into OFFixedVehicle (OFFVNum,LicensePlateNum,TopUpNum,TopUpDuration,ExpireTime,PSSystemNum) values ('{OFFVNum}','{licensePlateNum}','{date}','{timeLength}','{expireTime}','{parkSpot}')";
            OleDbCommand cmd2 = new OleDbCommand(insert_orderForm, database.dbConn);
            cmd2.ExecuteNonQuery();

            // 固定车辆表
            string select_vehicle = $"select * from VEFixedVehicle where LicensePlateNum = '{licensePlateNum}'";
            OleDbDataAdapter inst1 = new OleDbDataAdapter(select_vehicle, database.dbConn);
            DataTable dt1 = new DataTable();
            inst1.Fill(dt1);
            if (dt1.Rows.Count == 0)
            {
                string insert_fixedVehicle = $"insert into VEFixedVehicle (LicensePlateNum,CarOwnerID,WtPO,ParkingSpot,FvComment) values ('{licensePlateNum}','{OwnerID}','否','{parkSpot}','')";
                OleDbCommand cmd3 = new OleDbCommand(insert_fixedVehicle, database.dbConn);
                cmd3.ExecuteNonQuery();
            }

            // 收费单
            string chargeNum = GenerateChargeNum.ChargeNum(park);
            string select_cost = "select Cost from FIRates where RateNum = 'SX002'";
            OleDbDataAdapter inst2 = new OleDbDataAdapter(select_cost, database.dbConn);
            DataTable dt2 = new DataTable();
            inst2.Fill(dt2);
            string sum = (Convert.ToInt32(dt2.Rows[0][0]) * Convert.ToInt32(timeLength)).ToString();
            string insert_chargeNum = $"insert into FIVehicleCharge (ChargeNum,ChargeTime,Cost,OFNum) values ('{chargeNum}','{DateTime.Now.ToString()}','{sum}','{OFFVNum}')";
            OleDbCommand cmd4 = new OleDbCommand(insert_chargeNum, database.dbConn);
            cmd4.ExecuteNonQuery();

            database.dbConn.Close();
        }

        private void form_OrderFormInsert_Load(object sender, EventArgs e)
        {
            txtOwnerName.Focus();
        }
    }
}
