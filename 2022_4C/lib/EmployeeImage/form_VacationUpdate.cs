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
    public partial class form_VacationUpdate : Form
    {
        public form_VacationUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtNum.Text;
            string id = txtInfEmployeeID.Text;
            string reason = txtReason.Text;
            string time = dateTimePicker1.Text;

            string update = null;
            string select = null;

            if (num == string.Empty)    // 请假单号为空
            {
                DialogResult result = MessageBox.Show("请输入请假单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    txtNum.Clear();
                }
            }
            else
            {
                string select_1 = $@"select * from BALeave where LNum = '{num}'";
                OleDbDataAdapter cmd_1 = new OleDbDataAdapter(select_1, database.dbConn);
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
                    if (id == string.Empty && reason == string.Empty)
                    {
                        MessageBox.Show("至少需要输入一个值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (id != string.Empty && reason == string.Empty)    // id不为空
                    {
                        update = $@"update BALeave set EmployeeID = '{id}' where LNum = '{num}'";
                        select = $@"select * from BALeave where EmployeeID = '{id}'";
                    }
                    else if (id == string.Empty && reason != string.Empty)    // 请假事由不为空
                    {
                        update = $@"update BALeave set LeaveCause = '{reason}' where LNum = '{num}'";
                        select = $@"select * from BALeave where LeaveCause = '{reason}'";
                    }
                    else if (id == string.Empty && reason == string.Empty && checkBox1.Checked)    // 请假日期不为空
                    {
                        update = $@"update BALeave set LeaveTime = '{time}' where LNum = '{num}'";
                        select = $@"select * from BALeave where LeaveTime = '{time}'";
                    }
                    else if (id != string.Empty && reason != string.Empty)    // 请假日期为空
                    {
                        update = $@"update BALeave set EmployeeID = '{id}',LeaveCause = '{reason}' where LNum = '{num}'";
                        select = $@"select * from BALeave where EmployeeID = '{id}' and LeaveCause = '{reason}'";
                    }
                    else if (id != string.Empty && reason == string.Empty && checkBox1.Checked)    // 请假事由为空
                    {
                        update = $@"update BALeave set EmployeeID = '{id}',LeaveTime = '{time}' where LNum = '{num}'";
                        select = $@"select * from BALeave where EmployeeID = '{id}' and LeaveTime = '{time}'";
                    }
                    else if (id == string.Empty && reason != string.Empty && checkBox1.Checked)    // id为空
                    {
                        update = $@"update BALeave set LeaveCause = '{reason}',LeaveTime = '{time}' where LNum = '{num}'";
                        select = $@"select * from BALeave where LeaveTime = '{time}' and LeaveCause = '{reason}'";
                    }
                    else    // 都不为空
                    {
                        update = $@"update BALeave set EmployeeID = '{id}',LeaveTime = '{time}',LeaveCause = '{reason}' where LNum = '{num}'";
                        select = $@"select * from BALeave where LeaveTime = '{time}' and LeaveCause = '{reason}' and EmployeeID = '{id}'";
                    }
                    

                    OleDbDataAdapter cmd_2 = new OleDbDataAdapter(select, database.dbConn);
                    DataTable dt_2 = new DataTable();
                    cmd_2.Fill(dt_2);
                    if (dt_2.Rows.Count == 0)
                    {
                        DialogResult dialog = MessageBox.Show("未查到符合的数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog == DialogResult.OK)
                        {
                            txtNum.Clear();
                        }
                    }
                    else
                    {
                        OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                        cmd.ExecuteNonQuery();
                    }
                } 
            }
            database.dbConn.Close();

            this.Close();
        }
    }
}
