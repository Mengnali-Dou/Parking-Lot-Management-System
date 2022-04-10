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
    public partial class uc_sonCharge : UserControl
    {
        public uc_Rates uc_RA;
        public uc_VehicleCharge uc_VC;
        public uc_Disbursement uc_DI;

        public uc_sonCharge()
        {
            InitializeComponent();
            uc_RA = new uc_Rates();
            uc_VC = new uc_VehicleCharge();
            uc_DI = new uc_Disbursement();
        }

        private void btnRates_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            uc_RA.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_RA);
        }

        private void btnVehicleCharge_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(dataGridView1);

            uc_VC.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_VC);

            database.dbConn.Open();

            string select = "select * from FIVehicleCharge";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "收费编号";
            dataGridView1.Columns[1].HeaderText = "时间";
            dataGridView1.Columns[2].HeaderText = "收费金额";
            dataGridView1.Columns[3].HeaderText = "订单号";
            dataGridView1.Columns[4].HeaderText = "操作员";
            dataGridView1.Columns[5].HeaderText = "备注";
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        // TODO:财务报表在这儿
        private void btnFiance_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(dataGridView1);

            uc_DI.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_DI);

            database.dbConn.Open();

            string select = "select * from FIFiance";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "报表编号";
            dataGridView1.Columns[1].HeaderText = "时间";
            dataGridView1.Columns[2].HeaderText = "收取";
            dataGridView1.Columns[3].HeaderText = "收取订单数";
            dataGridView1.Columns[4].HeaderText = "支出金额";
            dataGridView1.Columns[5].HeaderText = "支出订单数";
            dataGridView1.Columns[6].HeaderText = "备注";
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }
    }
}
