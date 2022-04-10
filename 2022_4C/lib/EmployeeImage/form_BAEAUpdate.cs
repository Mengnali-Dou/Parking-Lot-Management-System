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
    public partial class form_BAEAUpdate : Form
    {
        public form_BAEAUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string ea_num = txtEANum.Text;
            string id = txtEmployeeID.Text;
            string invoice_num = txtInvoiceNum.Text;
            string ea_money = txtEAMoney.Text;
            string ea_project = txtEAProject.Text;
            string comment = rtxtComment.Text;

            if (ea_num == string.Empty)
            {
                DialogResult result2 = MessageBox.Show("请输入报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    txtEANum.Focus();
                }
            }
            else
            {
                if (id != string.Empty)
                {
                    string update_id = $"update BAExpenseAccount set EmployeeID = '{id}' where EANum = '{ea_num}'";
                    OleDbCommand cmd_id = new OleDbCommand(update_id, database.dbConn);
                    cmd_id.ExecuteNonQuery();
                }

                if (invoice_num != string.Empty)
                {
                    string update_inum = $"update BAExpenseAccount set InvoiceNum = '{invoice_num}' where EANum = '{ea_num}'";
                    OleDbCommand cmd_inum = new OleDbCommand(update_inum, database.dbConn);
                    cmd_inum.ExecuteNonQuery();
                }

                if (ea_money != string.Empty)
                {
                    string update_money = $"update BAExpenseAccount set EAMoney = '{ea_money}' where EANum = '{ea_num}'";
                    OleDbCommand cmd_money = new OleDbCommand(update_money, database.dbConn);
                    cmd_money.ExecuteNonQuery();
                }

                if (ea_project != string.Empty)
                {
                    string update_mproject = $"update BAExpenseAccount set EAProject = '{ea_project}' where EANum = '{ea_num}'";
                    OleDbCommand cmd_project = new OleDbCommand(update_mproject, database.dbConn);
                    cmd_project.ExecuteNonQuery();
                }

                if (comment != string.Empty)
                {
                    string update_comment = $"update BAExpenseAccount set EAComment = '{comment}' where EANum = '{ea_num}'";
                    OleDbCommand cmd_comment = new OleDbCommand(update_comment, database.dbConn);
                    cmd_comment.ExecuteNonQuery();
                }
            }
            database.dbConn.Close();
            DialogResult result3 = MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result3 == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string ea_num = txtEANum.Text;
            if (ea_num == string.Empty)
            {
                DialogResult result1 = MessageBox.Show("请输入报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtEANum.Focus();
                }
            }
            else
            {
                string select = $"select * from BAExpenseAccount where EANum = '{ea_num}'";
                OleDbDataAdapter cmd = new OleDbDataAdapter(select, database.dbConn);
                DataSet ds = new DataSet();
                cmd.Fill(ds);
                if (ds == null)
                {
                    DialogResult result1 = MessageBox.Show("未查询到该报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result1 == DialogResult.OK)
                    {
                        txtEANum.Focus();
                    }
                }
                else
                {
                    string sel_EmployeeId = $"select EmployeeID from BAExpenseAccount where EANum = '{ea_num}'";
                    OleDbDataAdapter cmd1 = new OleDbDataAdapter(sel_EmployeeId, database.dbConn);
                    DataSet ds1 = new DataSet();
                    cmd1.Fill(ds1);
                    txtEmployeeID.Text = Convert.ToString(ds1);

                    string sel_InvoiceNum = $"select EmployeeID from BAExpenseAccount where EANum = '{ea_num}'";
                    OleDbDataAdapter cmd2 = new OleDbDataAdapter(sel_InvoiceNum, database.dbConn);
                    DataSet ds2 = new DataSet();
                    cmd2.Fill(ds2);
                    txtInvoiceNum.Text = Convert.ToString(ds2);

                    string sel_EAMoney = $"select EmployeeID from BAExpenseAccount where EANum = '{ea_num}'";
                    OleDbDataAdapter cmd3 = new OleDbDataAdapter(sel_EAMoney, database.dbConn);
                    DataSet ds3 = new DataSet();
                    cmd2.Fill(ds3);
                    txtEAMoney.Text = Convert.ToString(ds3);

                    string sel_EAProject = $"select EmployeeID from BAExpenseAccount where EANum = '{ea_num}'";
                    OleDbDataAdapter cmd4 = new OleDbDataAdapter(sel_EAProject, database.dbConn);
                    DataSet ds4 = new DataSet();
                    cmd2.Fill(ds4);
                    txtEAProject.Text = Convert.ToString(ds4);

                    string sel_EAComment = $"select EmployeeID from BAExpenseAccount where EANum = '{ea_num}'";
                    OleDbDataAdapter cmd5 = new OleDbDataAdapter(sel_EAComment, database.dbConn);
                    DataSet ds5 = new DataSet();
                    cmd2.Fill(ds5);
                    rtxtComment.Text = Convert.ToString(ds5);
                }
            }
            database.dbConn.Close();
        }
    }
}
