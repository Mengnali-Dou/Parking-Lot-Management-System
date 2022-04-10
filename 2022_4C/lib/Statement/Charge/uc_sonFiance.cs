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
    public partial class uc_sonFiance : UserControl
    {
        public uc_Fiance uc_FI;

        public uc_sonFiance()
        {
            InitializeComponent();
            uc_FI = new uc_Fiance();
        }

        private void uc_sonFiance_Load(object sender, EventArgs e)
        {
            uc_FI.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_FI);

            database.dbConn.Open();

            string select = "select * from FIFiance";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "报表编号";
            dataGridView1.Columns[1].HeaderText = "时间";
            dataGridView1.Columns[2].HeaderText = "收费金额";
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = null;
            string date = null;
            string select = null;

            if (num == string.Empty)
            {
                select = $"select * from FIFiance where FiDate = '{date}'";
            }
            else
            {
                select = $"select * from FIFiance where FINum = '{num}'";
            }
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            database.dbConn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = null;

            select = "select * from FIFiance";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            database.dbConn.Close();
        }
    }
}
