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

namespace _2022_4C.lib.EmployeeImage
{
    public partial class uc_sonChaekingIn : UserControl
    {
        public uc_sonChaekingIn()
        {
            InitializeComponent();
        }

        private void uc_sonChaekingIn_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from BAAttendanceSheet";
            OleDbDataAdapter cmd = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "考勤单号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "签到时间";
            dataGridView1.Columns[3].HeaderText = "签退时间";
            dataGridView1.Columns[4].HeaderText = "备注";

            database.dbConn.Close();
        }

        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text;
            string num = txtASNum.Text;

            database.dbConn.Open();

            string select = null;

            if (id == string.Empty && num == string.Empty)    // 查询所有
            {
                select = $"select * from BAAttendanceSheet";
            }
            else if (id != string.Empty && num == string.Empty)    // 按员工id查询
            {
                OleDbDataAdapter cmd_confirm1 = new OleDbDataAdapter($@"select * from BAAttendanceSheet where Employee = '{id}'" ,database.dbConn);
                DataTable dt_confirm1 = new DataTable();
                cmd_confirm1.Fill(dt_confirm1);

                if (dt_confirm1.Rows.Count == 0)    // 未查询到员工id
                {
                    DialogResult result1 = MessageBox.Show("未查询到该员工ID的信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result1 == DialogResult.OK)
                    {
                        txtEmployeeID.Clear();
                    }
                }
                else
                {
                    select = $@"select * from BAAttendanceSheet where Employee = '{id}'";
                }
            }
            else if (num != string.Empty)    // 按考勤单号查询
            {
                OleDbDataAdapter cmd_confirm2 = new OleDbDataAdapter($@"select * from BAAttendanceSheet where ASNum = '{num}'", database.dbConn);
                DataTable dt_confirm2 = new DataTable();
                cmd_confirm2.Fill(dt_confirm2);

                if (dt_confirm2.Rows.Count == 0)    // 未查询到员工id
                {
                    DialogResult result2 = MessageBox.Show("未查询到该请假单号的信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        txtEmployeeID.Clear();
                    }
                }
                else
                {
                    select = $@"select * from BAAttendanceSheet where ASNum = '{num}'";
                }
            }
            OleDbDataAdapter cmd = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "考勤单号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "签到时间";
            dataGridView1.Columns[3].HeaderText = "签退时间";
            dataGridView1.Columns[4].HeaderText = "备注";
            database.dbConn.Close();
        }

        /// <summary>
        /// 标记为迟到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtNum.Text;
            if (num == string.Empty)
            {
                DialogResult result3 = MessageBox.Show("请输入请假单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result3 == DialogResult.OK)
                {
                    txtNum.Focus();
                }
            }
            else
            {
                string select = $@"select * from BAAttendanceSheet where ASNum = '{num}'";
                OleDbDataAdapter cmd_select = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt_select = new DataTable();
                cmd_select.Fill(dt_select);
                if (dt_select.Rows.Count == 0)
                {
                    DialogResult result4 = MessageBox.Show("未查询到请假单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result4 == DialogResult.OK)
                    {
                        txtNum.Focus();
                    }
                }
                else
                {
                    string update = $@"update BAAttendanceSheet set BAASComment = '迟到'";
                    OleDbCommand cmd_update = new OleDbCommand(update, database.dbConn);
                    cmd_update.ExecuteNonQuery();
                    OleDbDataAdapter inst = new OleDbDataAdapter($@"select * from BAAttendanceSheet where ASNum = '{num}'", database.dbConn);
                    DataSet ds_update = new DataSet();
                    inst.Fill(ds_update);
                    dataGridView1.DataSource = ds_update.Tables[0];
                }
            }
            database.dbConn.Close();
        }

        /// <summary>
        /// 标记为早退
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEarly_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtNum.Text;
            if (num == string.Empty)
            {
                DialogResult result3 = MessageBox.Show("请输入请假单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result3 == DialogResult.OK)
                {
                    txtNum.Focus();
                }
            }
            else
            {
                string select = $@"select * from BAAttendanceSheet where ASNum = '{num}'";
                OleDbDataAdapter cmd_select = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt_select = new DataTable();
                cmd_select.Fill(dt_select);
                if (dt_select.Rows.Count == 0)
                {
                    DialogResult result4 = MessageBox.Show("未查询到请假单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result4 == DialogResult.OK)
                    {
                        txtNum.Focus();
                    }
                }
                else
                {
                    string update = $@"update BAAttendanceSheet set BAASComment = '早退'";
                    OleDbCommand cmd_update = new OleDbCommand(update, database.dbConn);
                    cmd_update.ExecuteNonQuery();
                    OleDbDataAdapter inst = new OleDbDataAdapter($@"select * from BAAttendanceSheet where ASNum = '{num}'", database.dbConn);
                    DataSet ds_update = new DataSet();
                    inst.Fill(ds_update);
                    dataGridView1.DataSource = ds_update.Tables[0];
                }
            }
            database.dbConn.Close();
        }
    }
}
