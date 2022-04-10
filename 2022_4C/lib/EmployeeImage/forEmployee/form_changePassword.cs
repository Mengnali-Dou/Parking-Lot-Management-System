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
    public partial class form_changePassword : Form
    {
        public form_changePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string pwd = txtPWD.Text;
            string pwd2 = txtPWD2.Text;

            if (pwd == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPWD.Focus();
                }
            }
            else
            {
                if (pwd2 == string.Empty)
                {
                    DialogResult dialog2 = MessageBox.Show("请重新输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtPWD2.Focus();
                    }
                }
                else
                {
                    if (pwd != pwd2)
                    {
                        DialogResult dialog3 = MessageBox.Show("两次输入密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog3 == DialogResult.OK)
                        {
                            txtPWD2.Focus();
                        }
                    }
                    else
                    {
                        string select_id = "select ID from Cache where Num = 1";
                        OleDbDataAdapter inst1 = new OleDbDataAdapter(select_id, database.dbConn);
                        DataTable dt1 = new DataTable();
                        inst1.Fill(dt1);
                        string ID = dt1.Rows[0][0].ToString();

                        string update = $"update BAEmployee set EmployeePassword = '{pwd}' where EmployeeID = '{ID}'";
                        OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                        cmd.ExecuteNonQuery();

                        DialogResult dialog4 = MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog4 == DialogResult.OK)
                        {
                            
                        }
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
