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

namespace _2022_4C.lib.EmployeeImage.forEmployee
{
    public partial class uc_askForLeave : UserControl
    {
        public uc_askForLeave()
        {
            InitializeComponent();
        }

        private void uc_askForLeave_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select_id = "select ID from Cache where Num = 1";
            OleDbDataAdapter cmd = new OleDbDataAdapter(select_id, database.dbConn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            string id = dt.Rows[0][0].ToString();

            labID.Text = id;

            database.dbConn.Close();
        }

        private void btnAskForLeave_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string id = labID.Text;
            string beginTime = beginDate.ToString();
            string endTime = endDate.ToString();
            string reason = txtReason.Text;

            if (beginTime.CompareTo(endTime) > 0)
            {
                DialogResult result1 = MessageBox.Show("请假结束时间不应早于开始时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    endDate.Focus();
                }
            }
            else
            {
                if (reason == string.Empty)
                {
                    DialogResult result2 = MessageBox.Show("请假事由不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        txtReason.Focus();
                    }
                }
                else
                {
                    string LNum = GenerateLNum.LNum();
                    string insert = $"insert into BALeave (LNum,EmployeeID,LeaveTime,BackTime,LeaveCause) values ('{LNum}','{id}','{beginTime}','{endTime}','{reason}')";
                    OleDbCommand cmd = new OleDbCommand(insert, database.dbConn);
                    cmd.ExecuteNonQuery();

                    DialogResult result3 = MessageBox.Show("完成", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result3 == DialogResult.OK)
                    {
                        txtReason.Focus();
                    }
                }
            }

            database.dbConn.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string id = labID.Text;

            string select_Sheet = $"select * from BALeave where EmployeeID = '{id}'";
            OleDbDataAdapter cmd2 = new OleDbDataAdapter(select_Sheet, database.dbConn);
            DataSet ds1 = new DataSet();
            cmd2.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.Columns[0].HeaderText = "编号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "请假时间";
            dataGridView1.Columns[3].HeaderText = "销假时间";
            dataGridView1.Columns[4].HeaderText = "请假事由";
            dataGridView1.Columns[5].HeaderText = "备注";

            database.dbConn.Close();
        }
    }
}
