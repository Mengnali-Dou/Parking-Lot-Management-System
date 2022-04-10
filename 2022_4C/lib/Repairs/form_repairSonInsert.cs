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

namespace _2022_4C.lib.Repairs
{
    public partial class form_repairSonInsert : Form
    {
        public form_repairSonInsert()
        {
            InitializeComponent();
        }

        public string Date()
        {
            DateTime dt = DateTime.Now;
            string date = dt.ToShortDateString().ToString();
            return date;
        }

        private void form_repairSonInsert_Load(object sender, EventArgs e)
        {
            labDate.Text = Date();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtMalNum.Text;
            string date = "";
            date = Date();
            string type = txtMalType.Text;
            string goods = txtMalGoods.Text;
            string place = rtxtMalPlace.Text;
            string malfunction = "否";
            string oper = txtChargeOperator.Text;
            string comment = rtxtComment.Text;
            string insert = null;

            if (num == string.Empty || type == string.Empty || goods == String.Empty || place == string.Empty || oper == string.Empty)
            {
                DialogResult dialog = MessageBox.Show("不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtMalNum.Focus();
                }
            }
            else
            {
                if (comment == string.Empty)
                {
                    insert = $"insert into TRMalfunction (MalNum,MalTime,MalType,MalGoods,MalPlace,Malfunction,ChargeOperator,MalComment) values ('{num}','{date}','{type}','{goods}','{place}','{malfunction}','{oper}','')";
                }
                else
                {
                    insert = $"insert into TRMalfunction (MalNum,MalTime,MalType,MalGoods,MalPlace,Malfunction,ChargeOperator,MalComment) values ('{num}','{date}','{type}','{goods}','{place}','{malfunction}','{oper}','{comment}')";
                }
                OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn); 
                myCommand.ExecuteNonQuery();
                database.dbConn.Close();
                DialogResult result = MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            database.dbConn.Close();
        }
    }
}
