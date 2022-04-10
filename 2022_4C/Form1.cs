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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string id = txtID.Text;
            string password = txtPassword.Text;

            if (id == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtID.Focus();
                }
            }
            else
            {
                if (password == string.Empty)
                {
                    DialogResult dialog2 = MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtPassword.Focus();
                    }
                }
                else
                {
                    Regex regexAdmin = new Regex("admin", RegexOptions.IgnoreCase);
                    Regex regexEmployee = new Regex("em", RegexOptions.IgnoreCase);
                    Regex regexUser = new Regex("FV", RegexOptions.IgnoreCase);

                    if (regexAdmin.IsMatch(id))    // 管理员登录
                    {
                        string selectAdmin = $"select AdminName,AdminPassword from BAAdmin where AdminID = '{id}'";
                        OleDbDataAdapter inst1 = new OleDbDataAdapter(selectAdmin, database.dbConn);
                        DataTable dt1 = new DataTable();
                        inst1.Fill(dt1);

                        if (dt1.Rows.Count == 0)
                        {
                            DialogResult dialog3 = MessageBox.Show("不存在此账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog3 == DialogResult.OK)
                            {
                                txtID.Focus();
                            }
                        }
                        else
                        {
                            // 判断密码正确性
                            if (password == dt1.Rows[0][1].ToString())
                            {
                                // 账号、姓名传缓存里
                                InsertUserInformation.id(id);
                                InsertUserInformation.user(dt1.Rows[0][0].ToString());

                                // 打开操作界面
                                FormMainAdmin frmMain = new FormMainAdmin();
                                this.Hide();
                                frmMain.Show();
                            }
                            else
                            {
                                DialogResult dialog4 = MessageBox.Show("密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (dialog4 == DialogResult.OK)
                                {
                                    txtPassword.Focus();
                                }
                            }
                        }
                    }
                    else if (regexEmployee.IsMatch(id))    // 员工登录
                    {
                        string selectEmployee = $"select EmployeeName,EmployeePassword from BAEmployee where EmployeeID = '{id}'";
                        OleDbDataAdapter inst2 = new OleDbDataAdapter(selectEmployee, database.dbConn);
                        DataTable dt2 = new DataTable();
                        inst2.Fill(dt2);

                        // 员工登录
                        if (dt2.Rows.Count == 0)
                        {
                            DialogResult dialog5 = MessageBox.Show("不存在此账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog5 == DialogResult.OK)
                            {
                                txtID.Focus();
                            }
                        }
                        else
                        {
                            if (password == dt2.Rows[0][1].ToString())
                            {
                                // 考勤
                                string ASNum = GenerateASNum.ASNum();
                                string OnDutyTime = DateTime.Now.ToString();
                                string insert_AttendanceSheet = $"insert into BAAttendanceSheet (ASNum,EmployeeID,OnDutyTime) values ('{ASNum}','{id}','{OnDutyTime}')";
                                OleDbCommand cmd = new OleDbCommand(insert_AttendanceSheet, database.dbConn);
                                cmd.ExecuteNonQuery();

                                // 存缓存
                                InsertUserInformation.id(id);
                                InsertUserInformation.user(dt2.Rows[0][0].ToString());
                                InsertUserInformation.ASNum(ASNum);

                                // TODO:打开操作界面
                                FormMainEmployee frmEmployee = new FormMainEmployee();
                                this.Hide();
                                frmEmployee.Show();

                            }
                            else
                            {
                                DialogResult dialog6 = MessageBox.Show("密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (dialog6 == DialogResult.OK)
                                {
                                    txtPassword.Focus();
                                }
                            }
                        }
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("账号错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog == DialogResult.OK)
                        {
                            txtPassword.Focus();
                        }
                    }
                }
            }

            database.dbConn.Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //int height = this.Height;
            //btnLogin.Height = height / 4 - 5;
            //btnQuit.Height = height / 4 - 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
