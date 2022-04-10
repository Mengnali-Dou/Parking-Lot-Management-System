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
    public partial class uc_ChangeEmployee : UserControl
    {
        public uc_ChangeEmployee()
        {
            InitializeComponent();
        }

        private void btnUpdateThis_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string id = txtEmployeeID.Text;
            string pwd = txtNewPD.Text;
            string pwd2 = txtNewPd2.Text;

            if (id == string.Empty)
            {
                DialogResult result1 = MessageBox.Show("请输入员工ID", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtEmployeeID.Focus();
                }
            }
            else
            {
                OleDbDataAdapter inst = new OleDbDataAdapter($"select * from BAEmployee where EmployeeID = '{id}'", database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult result5 = MessageBox.Show("未查询到该员工ID", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result5 == DialogResult.OK)
                    {
                        txtEmployeeID.Focus();
                    }
                }
                else
                {
                    if (pwd == string.Empty)
                    {
                        DialogResult result2 = MessageBox.Show("请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result2 == DialogResult.OK)
                        {
                            txtNewPD.Focus();
                        }
                    }
                    else
                    {
                        if (pwd2 == string.Empty)
                        {
                            DialogResult result3 = MessageBox.Show("请输入重新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result3 == DialogResult.OK)
                            {
                                txtNewPd2.Focus();
                            }
                        }
                        else
                        {
                            if (pwd != pwd2)
                            {
                                DialogResult result4 = MessageBox.Show("请两次密码输入不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (result4 == DialogResult.OK)
                                {
                                    txtNewPd2.Focus();
                                }
                            }
                            else
                            {
                                string update = $"update BAEmployee set EmployeePassword = '{pwd2}' where EmployeeID = '{id}'";
                                OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                
            }
            database.dbConn.Close();
        }
    }
}
