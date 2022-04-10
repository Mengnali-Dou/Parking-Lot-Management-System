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
    public partial class uc_sonExpend : UserControl
    {
        public uc_Disbursement uc_DI;
        public uc_ReturnRent uc_RR;

        public uc_sonExpend()
        {
            InitializeComponent();
            uc_DI = new uc_Disbursement();
            uc_RR = new uc_ReturnRent();
        }

        private void btnDisbursement_Click(object sender, EventArgs e)
        {
            uc_DI.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_DI);

            database.dbConn.Open();

            string select = "select * from FIDisbursement";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "支出编号";
            dataGridView1.Columns[1].HeaderText = "时间";
            dataGridView1.Columns[2].HeaderText = "支出项目";
            dataGridView1.Columns[3].HeaderText = "支出金额";
            dataGridView1.Columns[4].HeaderText = "操作员";
            dataGridView1.Columns[5].HeaderText = "备注";
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnReturnRent_Click(object sender, EventArgs e)
        {
            uc_RR.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_RR);

            database.dbConn.Open();

            string select = "select * from FIReturnRent";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "支出编号";
            dataGridView1.Columns[1].HeaderText = "时间";
            dataGridView1.Columns[2].HeaderText = "返还金额";
            dataGridView1.Columns[3].HeaderText = "返还车主";
            dataGridView1.Columns[4].HeaderText = "车位";
            dataGridView1.Columns[5].HeaderText = "操作员";
            dataGridView1.Columns[6].HeaderText = "备注";
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }
    }
}
