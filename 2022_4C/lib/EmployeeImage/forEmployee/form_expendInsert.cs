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
    public partial class form_expendInsert : Form
    {
        public form_expendInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select_ID = $"select ID from Cache where Num = 1";
            OleDbDataAdapter inst1 = new OleDbDataAdapter(select_ID, database.dbConn);
            DataTable dt1 = new DataTable();
            inst1.Fill(dt1);
            string ID = dt1.Rows[0][0].ToString();

            string invoiceNum = txtInvoiceNum.Text;
            string money = txtMoney.Text;
            string project = txtProject.Text;
            string comment = rtxtComment.Text;

            if (invoiceNum == string.Empty || money == string.Empty || project == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("除备注外不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtInvoiceNum.Focus();
                }
            }
            else
            {
                string EANum = GenerateEANum.EANum();

                string insert = $"insert into BAExpenseAccount (EANum,EmployeeID,InvoiceNum,EAMoney,EAProject,EAComment) values ('{EANum}','{ID}','{invoiceNum}','{money}','{project}','{comment}')";
                OleDbCommand cmd = new OleDbCommand(insert, database.dbConn);
                cmd.ExecuteNonQuery();

                DialogResult dialog2 = MessageBox.Show("完成", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog2 == DialogResult.OK)
                {
                    
                }
            }

            database.dbConn.Close();
        }
    }
}
