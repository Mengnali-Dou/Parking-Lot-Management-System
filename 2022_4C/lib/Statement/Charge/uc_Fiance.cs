using _2022_4C.data;
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

namespace _2022_4C.lib.Statement.Charge
{
    public partial class uc_Fiance : UserControl
    {
        public uc_Fiance()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string comment = null;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入报表编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtLONum.Focus();
                }
            }
            else
            {
                string select = $"select * from FIFiance where FINum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog1 = MessageBox.Show("未查询到此报表编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog1 == DialogResult.OK)
                    {
                        txtLONum.Focus();
                    }
                }
                else
                {
                    string sel = $"select FiComment from FIFiance where FINum = '{num}'";
                    OleDbDataAdapter inst_sel = new OleDbDataAdapter(sel, database.dbConn);
                    DataTable dt_sel = new DataTable();
                    inst_sel.Fill(dt_sel);
                    rtxtComment.Text = dt_sel.Rows[0][0].ToString();
                }
            }

            database.dbConn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string comment = rtxtComment.Text;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入报表编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtLONum.Focus();
                }
            }
            else
            {
                string select = $"select * from FIFiance where FINum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog1 = MessageBox.Show("未查询到此报表编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog1 == DialogResult.OK)
                    {
                        txtLONum.Focus();
                    }
                }
                else
                {
                    string update = $"update FIFiance set FiComment = '{comment}' where FiNum = '{num}'";
                    OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                    cmd.ExecuteNonQuery();
                }
            }

            database.dbConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            DateTime dt = DateTime.Now;
            string date = dt.ToShortDateString().ToString();

            string charge_sum = null;
            string charge_num = null;
            string dis_sum = null;
            string dis_num = null;
            string num = null;
            string comment = null;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入报表编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtLONum.Focus();
                }
            }
            else
            {
                string sel_1 = $"select sum(cost) from FIVehicleCharge group by ChargeTime having ChargeTime = '{date}'";
                OleDbDataAdapter inst1 = new OleDbDataAdapter(sel_1, database.dbConn);
                DataTable dt1 = new DataTable();
                inst1.Fill(dt1);
                charge_num = dt1.Rows[0][0].ToString();

                string sel_2 = $"select count(ChargeNum) from FIVehicleCharge group by ChargeTime having ChargeTime = '{date}'";
                OleDbDataAdapter inst2 = new OleDbDataAdapter(sel_2, database.dbConn);
                DataTable dt2 = new DataTable();
                inst2.Fill(dt2);
                charge_sum = dt2.Rows[0][0].ToString();

                string sel_3 = $"select sum(DisSum) from FIDisbursement group by DisTime having DisTime = '{date}'";
                OleDbDataAdapter inst3 = new OleDbDataAdapter(sel_3, database.dbConn);
                DataTable dt3 = new DataTable();
                inst3.Fill(dt3);
                charge_sum = dt3.Rows[0][0].ToString();

                string sel_4 = $"select count(DisNum) from FIDisbursement group by DisTime having DisTime = '{date}'";
                OleDbDataAdapter inst4 = new OleDbDataAdapter(sel_4, database.dbConn);
                DataTable dt4 = new DataTable();
                inst4.Fill(dt4);
                charge_sum = dt4.Rows[0][0].ToString();

                string select = $"select * from FIFiance where FINum = '{num}'";
                OleDbDataAdapter inst5 = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt5 = new DataTable();
                inst5.Fill(dt5);

                string insert = null;
                if (dt5.Rows.Count != 0)
                {
                    insert = $@"update FIFiance set ChargeNum = '{charge_sum}',ChargeOF = '{charge_num}',DisNum = '{dis_sum}',DisOF = '{dis_num}' where FINum = '{num}'";
                }
                else
                {
                    insert = $@"insert FIFiance (FINum,FiDate,ChargeNum,ChargeOF,DisNum,DisOF,FIComment) values ('{num}','{date}','{charge_sum}','{charge_num}','{dis_sum}','{dis_num}','{comment}')";
                }
                OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);
                myCommand.ExecuteNonQuery();
            }

            database.dbConn.Close();
        }
    }
}
