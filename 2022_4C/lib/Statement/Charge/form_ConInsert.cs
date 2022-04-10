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
    public partial class form_ConInsert : Form
    {
        public form_ConInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtNum.Text;
            string type = txtType.Text;
            string comment = rtxtComment.Text;

            if (num == string.Empty || type == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("除备注外不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtNum.Focus();
                }
            }
            else
            {
                string insert = $"insert into PUConstructionItem (ItemNum,ItemType,ItemComment) values ('{num}','{type}','{comment}')";
                OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);
                myCommand.ExecuteNonQuery();
                DialogResult dialog2 = MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog2 == DialogResult.OK)
                {
                    txtNum.Focus();
                }
            }

            database.dbConn.Close();
        }
    }
}
