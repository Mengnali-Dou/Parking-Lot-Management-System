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
    public partial class form_Equ : Form
    {
        public form_Equ()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string pur_num = txtPurNum.Text;
            string date = dateTimePicker1.Text;
            string equ_num = txtEquNum.Text;
            string amount = txtAmount.Text;
            string sum = txtSum.Text;
            string park = txtPark.Text;
            string oper = txtOperator.Text;
            string comment = rtxtComment.Text;

            if (pur_num == string.Empty || date == string.Empty || equ_num == string.Empty || amount == string.Empty || sum == string.Empty || park == string.Empty || oper == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("除备注外不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPurNum.Focus();
                }
            }
            else
            {
                string insert = $"insert into PUEquipmentPurchasing (PurNum,PurDate,EquNum,PurAmount,PurSum,ParkNum,ChargeOperator,PurComment) values ('{pur_num}','{date}','{equ_num}','{amount}','{sum}','{park}','{oper}','{comment}')";
                OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);    // 执行SQL语句
                myCommand.ExecuteNonQuery();
                DialogResult dialog1 = MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPurNum.Focus();
                }
            }

            database.dbConn.Close();
        }
    }
}
