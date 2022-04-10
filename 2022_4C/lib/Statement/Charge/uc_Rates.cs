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
    public partial class uc_Rates : UserControl
    {
        public uc_Rates()
        {
            InitializeComponent();
        }

        private void uc_Rates_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num_1 = "select Cost from FIRates where RateNum = 'SX001'";
            OleDbDataAdapter inst_1 = new OleDbDataAdapter(num_1, database.dbConn);
            DataTable dt_1 = new DataTable();
            inst_1.Fill(dt_1);
            txt1.Text = dt_1.Rows[0][0].ToString();

            string num_2 = "select Cost from FIRates where RateNum = 'SX002'";
            OleDbDataAdapter inst_2 = new OleDbDataAdapter(num_2, database.dbConn);
            DataTable dt_2 = new DataTable();
            inst_2.Fill(dt_2);
            txt2.Text = dt_2.Rows[0][0].ToString();

            string num_3 = "select Cost from FIRates where RateNum = 'SX003'";
            OleDbDataAdapter inst_3 = new OleDbDataAdapter(num_3, database.dbConn);
            DataTable dt_3 = new DataTable();
            inst_3.Fill(dt_3);
            txt3.Text = dt_3.Rows[0][0].ToString();

            database.dbConn.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num_1 = "select Cost from FIRates where RateNum = 'SX001'";
            OleDbDataAdapter inst_1 = new OleDbDataAdapter(num_1, database.dbConn);
            DataTable dt_1 = new DataTable();
            inst_1.Fill(dt_1);
            txt1.Text = dt_1.Rows[0][0].ToString();

            string num_2 = "select Cost from FIRates where RateNum = 'SX002'";
            OleDbDataAdapter inst_2 = new OleDbDataAdapter(num_2, database.dbConn);
            DataTable dt_2 = new DataTable();
            inst_2.Fill(dt_2);
            txt2.Text = dt_2.Rows[0][0].ToString();

            string num_3 = "select Cost from FIRates where RateNum = 'SX003'";
            OleDbDataAdapter inst_3 = new OleDbDataAdapter(num_3, database.dbConn);
            DataTable dt_3 = new DataTable();
            inst_3.Fill(dt_3);
            txt3.Text = dt_3.Rows[0][0].ToString();

            database.dbConn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string cost_1 = txt1.Text;
            string cost_2 = txt2.Text;
            string cost_3 = txt3.Text;

            DialogResult dialog1 = MessageBox.Show("确定要修改？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog1 == DialogResult.OK)
            {
                string num_1 = $"update FIRates set Cost = '{cost_1}' where RateNum = 'SX001'";
                OleDbDataAdapter inst_1 = new OleDbDataAdapter(num_1, database.dbConn);
                DataTable dt_1 = new DataTable();

                string num_2 = "update FIRates set Cost = '{cost_2}' where RateNum = 'SX002'";
                OleDbDataAdapter inst_2 = new OleDbDataAdapter(num_2, database.dbConn);
                DataTable dt_2 = new DataTable();

                string num_3 = "update FIRates set Cost = '{cost_3}' where RateNum = 'SX003'";
                OleDbDataAdapter inst_3 = new OleDbDataAdapter(num_3, database.dbConn);
                DataTable dt_3 = new DataTable();
            }

            database.dbConn.Close();
        }
    }
}
