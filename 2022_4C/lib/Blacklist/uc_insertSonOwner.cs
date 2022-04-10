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

namespace _2022_4C.lib.Blacklist
{
    public partial class uc_insertSonOwner : UserControl
    {
        public uc_insertSonOwner()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            DateTime dt = DateTime.Now;
            string id = txtOwnerID.Text;
            string name = txtOwnerName.Text;
            string reason = txtReason.Text;
            string date = dt.ToShortDateString().ToString();
            string oper = txtOperator.Text;
            string comment = txtComment.Text;
            string insert = null;

            if (id == string.Empty || name == string.Empty || reason == string.Empty || oper == string.Empty)
            {
                DialogResult result1 = MessageBox.Show("查询条件不能有空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtOwnerID.Focus();
                }
            }
            else
            {
                if (comment == string.Empty)
                {
                    insert = $"insert INOwnerBlacklist (OwnerID,OwnerName,OSignReason,OSignTime,OOperator) values ('{id}','{name}','{reason}','{date}','{oper}')";
                }
                else
                {
                    insert = $"insert INOwnerBlacklist (OwnerID,OwnerName,OSignReason,OSignTime,OOperator,OComment) values ('{id}','{name}','{reason}','{date}','{oper}','{comment}')";
                }
                OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);    // 执行SQL语句
                myCommand.ExecuteNonQuery();
                DialogResult result1 = MessageBox.Show("标记成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtOwnerID.Focus();
                }
            }
            database.dbConn.Close();
        }
    }
}
