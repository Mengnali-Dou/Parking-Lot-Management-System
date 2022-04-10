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
    public partial class form_BAEAInsert : Form
    {
        
        static DateTime DT = System.DateTime.Now;
        static int dtYear = DT.Year;
        static int dtMonth = DT.Month;
        static int dtDay = DT.Day;
        static int dtMin = DT.Minute;
        static int year = dtYear - 2000;
        static string ea_num = "EA" + $"{Convert.ToString(year)}" + $"{Convert.ToString(dtMonth)}" + $"{Convert.ToString(dtDay)}" + $"{Convert.ToString(dtMin)}" + "1";

        public form_BAEAInsert()
        {
            InitializeComponent();
        }

        private void form_BAEAInsert_Load(object sender, EventArgs e)
        {
            lab.Text = ea_num;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();
            
            string id = txtEmployeeID.Text;
            string invoice_num = txtInvoiceNum.Text;
            string ea_money = txtEAMoney.Text;
            string ea_project = txtEAProject.Text;
            string comment = rtxtComment.Text;

            string select = $"select * from BAExpenseAccount where EmployeeID = '{id}'";
            OleDbDataAdapter sel = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            sel.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                DialogResult result1 = MessageBox.Show("未查询到该员工ID的信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtEmployeeID.Clear();
                }
            }
            else
            {
                if (id == string.Empty || invoice_num == string.Empty || ea_money == string.Empty || ea_project == string.Empty)
                {
                    DialogResult result1 = MessageBox.Show("不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result1 == DialogResult.OK)
                    {
                        txtEmployeeID.Focus();
                    }
                }
                else
                {
                    string insert = $"insert into BAExpenseAccount (EANum,EmployeeID,InvoiceNum,EAMoney,EAProject,EAComment) values ('{ea_num}', '{id}', '{invoice_num}', '{ea_money}', '{ea_project}', '{comment}')";
                    OleDbCommand cmd = new OleDbCommand(insert, database.dbConn);
                    DialogResult result2 = MessageBox.Show("插入成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        database.dbConn.Close();
                        this.Close();
                    }
                }
            }
            database.dbConn.Close();
            
        }
    }
}
