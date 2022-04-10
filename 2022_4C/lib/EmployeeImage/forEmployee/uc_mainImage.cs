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
    public partial class uc_mainImage : UserControl
    {
        public uc_askForLeave uc_FL;

        public uc_mainImage()
        {
            InitializeComponent();
            uc_FL = new uc_askForLeave();
        }

        private void btnAskForLeave_Click(object sender, EventArgs e)
        {
            uc_FL.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_FL);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(dataGridView1);

            database.dbConn.Open();

            string select_ID = $"select ID from Cache where Num = 1";
            OleDbDataAdapter inst1 = new OleDbDataAdapter(select_ID, database.dbConn);
            DataTable dt1 = new DataTable();
            inst1.Fill(dt1);
            string ID = dt1.Rows[0][0].ToString();

            string select = $"select * from BAAttendanceSheet where EmployeeID = '{ID}'";
            OleDbDataAdapter inst2 = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds1 = new DataSet();
            inst2.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.Columns[0].HeaderText = "考勤单号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "签到时间";
            dataGridView1.Columns[3].HeaderText = "签退时间";
            dataGridView1.Columns[4].HeaderText = "备注";

            database.dbConn.Close();
        }

        private void btnExpend_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            form_changePassword form = new form_changePassword();
            form.ShowDialog();
        }
    }
}
