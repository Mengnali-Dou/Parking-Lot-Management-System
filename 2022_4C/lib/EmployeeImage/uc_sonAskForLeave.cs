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
    public partial class uc_sonAskForLeave : UserControl
    {
        public uc_sonAskForLeave()
        {
            InitializeComponent();
        }

        private void uc_sonAskForLeave_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();
            string select = "select * from BALeave";
            OleDbDataAdapter cmd = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "请假单号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "请假时间";
            dataGridView1.Columns[3].HeaderText = "销假时间";
            dataGridView1.Columns[4].HeaderText = "请假事由";
            dataGridView1.Columns[5].HeaderText = "备注";
            database.dbConn.Close();
        }

        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();
            string id = txtInfEmployeeID.Text;    // 员工ID
            string date = dateTimePicker1.Text;    // 时间
            string select = null;
            if (id == string.Empty)    // ID、时间均为空
            {
                select = $"select * from BALeave";
            }
            else if (id == string.Empty && checkBox1.Checked)    // ID为空
            {
                select = $"select * from BALeave where LeaveDate = '{date}'";
            }
            else if (id != string.Empty)    // 时间为空
            {
                select = $"select * from BALeave where EmployeeID = '{id}'";
            }
            else    // ID、时间都不为空
            {
                select = $"select * from BALeave where LeaveDate = '{date}' and EmployeeID = '{id}'";
            }
            OleDbDataAdapter cmd = new OleDbDataAdapter(select,database.dbConn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "请假单号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "请假时间";
            dataGridView1.Columns[3].HeaderText = "返回时间";
            dataGridView1.Columns[4].HeaderText = "请假事由";
            dataGridView1.Columns[5].HeaderText = "备注";
            database.dbConn.Close();
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons affirm = MessageBoxButtons.OKCancel;
            MessageBoxIcon warning = MessageBoxIcon.Warning;
            DialogResult result =  MessageBox.Show("正在执行删除操作", "警告", affirm, warning);
            ResultMsg(result);
        }
        
        /// <summary>
        /// 判断警告窗口操作
        /// </summary>
        /// <param name="outcome"></param>
        private void ResultMsg(DialogResult outcome)
        {
            if (outcome == DialogResult.OK)
            {
                database.dbConn.Open();

                string id = txtInfEmployeeID.Text;    // 员工ID
                string date = dateTimePicker1.Text;    // 时间

                // 判断ID框中是否为空
                if (id == string.Empty)
                {
                    DialogResult dialog =  MessageBox.Show("请输入员工ID", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        txtInfEmployeeID.Focus();
                    }
                }
                else
                {
                    // 判断有没有这条数据
                    string select = $@"select * from BALeave where EmployeeID = '{id}' and LeaveDate = '{date}'";
                    OleDbDataAdapter cmd_1 = new OleDbDataAdapter(select, database.dbConn);
                    DataTable dt_1 = new DataTable();
                    cmd_1.Fill(dt_1);
                    if (dt_1.Rows.Count == 0)
                    {
                        txtInfEmployeeID.Clear();
                    }
                    else
                    {
                        // 删除
                        string delete = $"delete * from BALeave where EmployeeID = '{id}' and LeaveDate = '{date}'";
                        OleDbCommand cmd = new OleDbCommand(delete, database.dbConn);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 删除后更新显示表中数据
                OleDbDataAdapter inst = new OleDbDataAdapter("select * from BALeave", database.dbConn);
                DataSet ds = new DataSet();
                inst.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                database.dbConn.Close();
            }
            else
            {
                txtInfEmployeeID.Clear();
            }
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            form_VacationUpdate form = new form_VacationUpdate();
            form.ShowDialog();
        }

        /// <summary>
        /// 请假按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeave_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            if (Convert.ToString(txtNum.Text) == string.Empty)
            {
                DialogResult dialog = MessageBox.Show("请输入请假单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtNum.Clear();
                }
            }
            else
            {
                string num = txtNum.Text;
                string leave_select = $@"select * from BALeave where LNum = '{num}'";
                OleDbDataAdapter cmd_1 = new OleDbDataAdapter(leave_select, database.dbConn);
                DataTable dt_1 = new DataTable();
                cmd_1.Fill(dt_1);
                if (dt_1.Rows.Count == 0)    // 未查询到请假单号
                {
                    DialogResult dialog = MessageBox.Show("未查到该单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        txtNum.Clear();
                    }
                }
                else
                {
                    string update = $@"update BALeave set LComment = '请假完成'";
                    OleDbCommand cmd_2 = new OleDbCommand(update, database.dbConn);
                    cmd_2.ExecuteNonQuery();
                    OleDbDataAdapter sel_1 = new OleDbDataAdapter($@"select * from BALeave where LNum = '{num}'", database.dbConn);
                    DataSet ds_2 = new DataSet();
                    sel_1.Fill(ds_2);
                    dataGridView1.DataSource = ds_2.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "请假单号";
                    dataGridView1.Columns[1].HeaderText = "员工账号";
                    dataGridView1.Columns[2].HeaderText = "请假时间";
                    dataGridView1.Columns[3].HeaderText = "返回时间";
                    dataGridView1.Columns[4].HeaderText = "请假事由";
                    dataGridView1.Columns[5].HeaderText = "备注";
                }
            }
            database.dbConn.Close();
        }

        /// <summary>
        /// 销假按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            if (Convert.ToString(txtNum.Text) == string.Empty)
            {
                DialogResult dialog = MessageBox.Show("请输入请假单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtNum.Clear();
                }
            }
            else
            {
                string num = txtNum.Text;
                string leave_select = $@"select * from BALeave where LNum = '{num}'";
                OleDbDataAdapter cmd_1 = new OleDbDataAdapter(leave_select, database.dbConn);
                DataTable dt_1 = new DataTable();
                cmd_1.Fill(dt_1);
                if (dt_1.Rows.Count == 0)    // 未查询到请假单号
                {
                    DialogResult dialog = MessageBox.Show("未查到该单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        txtNum.Clear();
                    }
                }
                else
                {
                    string update = $@"update BALeave set LComment = '销假完成'";
                    OleDbCommand cmd_2 = new OleDbCommand(update, database.dbConn);
                    cmd_2.ExecuteNonQuery();
                    OleDbDataAdapter sel_1 = new OleDbDataAdapter($@"select * from BALeave where LNum = '{num}'", database.dbConn);
                    DataSet ds_2 = new DataSet();
                    sel_1.Fill(ds_2);
                    dataGridView1.DataSource = ds_2.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "请假单号";
                    dataGridView1.Columns[1].HeaderText = "员工账号";
                    dataGridView1.Columns[2].HeaderText = "请假时间";
                    dataGridView1.Columns[3].HeaderText = "返回时间";
                    dataGridView1.Columns[4].HeaderText = "请假事由";
                    dataGridView1.Columns[5].HeaderText = "备注";
                }
            }
            database.dbConn.Close();
        }
    }
}
