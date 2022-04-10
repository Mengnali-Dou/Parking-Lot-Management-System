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

namespace _2022_4C.lib.Statement.Charge
{
    public partial class form_Eng : Form
    {
        public form_Eng()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string con_num = txtConNum.Text;
            string item_num = txtItemNum.Text;
            string item_name = txtItemName.Text;
            string begin_date = dtpBegin.Text;
            string end_date = dtpEnd.Text;
            string park = txtPark.Text;
            string sum = txtSum.Text;
            string oper = txtOperator.Text;
            string comment = rtxtComment.Text;

            if (con_num == string.Empty || item_num == string.Empty || item_name == string.Empty || park == string.Empty || sum == string.Empty || oper == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("除备注外不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtConNum.Focus();
                }
            }
            else
            {
                if (Convert.ToDateTime(begin_date) > Convert.ToDateTime(end_date))
                {
                    DialogResult dialog1 = MessageBox.Show("时间错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog1 == DialogResult.OK)
                    {
                        dtpEnd.Focus();
                    }
                }
                else
                {
                    string insert = $"insert into PUEngineeringConstruction (ConNum,ItemNum,ItemName,BeginDate,EndDate,ConPark,ConSum,ChargeOperator,ConComment) values ('{con_num}','{item_num}','{item_name}','{begin_date}','{end_date}','{park}','{sum}','{oper}','{comment}')";
                    OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);    // 执行SQL语句
                    myCommand.ExecuteNonQuery();
                    DialogResult dialog1 = MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog1 == DialogResult.OK)
                    {
                        txtConNum.Focus();
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
