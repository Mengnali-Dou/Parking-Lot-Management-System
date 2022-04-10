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

namespace _2022_4C.lib.EmployeeImage.forEmployee
{
    public partial class uc_expend : UserControl
    {
        public uc_expend()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select_ID = $"select ID from Cache where Num = 1";
            OleDbDataAdapter inst1 = new OleDbDataAdapter(select_ID, database.dbConn);
            DataTable dt1 = new DataTable();
            inst1.Fill(dt1);
            string ID = dt1.Rows[0][0].ToString();

            string select = $"select * from BAExpenseAccount where EmployeeID = '{ID}'";
            OleDbDataAdapter inst2 = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds1 = new DataSet();
            inst2.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.Columns[0].HeaderText = "报销单号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "发票单号";
            dataGridView1.Columns[3].HeaderText = "报销金额";
            dataGridView1.Columns[4].HeaderText = "报销项目";
            dataGridView1.Columns[5].HeaderText = "备注";

            database.dbConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
