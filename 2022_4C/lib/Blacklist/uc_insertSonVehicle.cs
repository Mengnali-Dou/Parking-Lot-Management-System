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
    public partial class uc_insertSonVehicle : UserControl
    {
        public uc_insertSonVehicle()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            DateTime dt = DateTime.Now;
            string license = txtPlateLicense.Text;
            string reason = rtxtReason.Text;
            string date = dt.ToShortDateString().ToString();
            string oper = txtOperator.Text;
            string comment = rtxtComment.Text;

            if (license == string.Empty || reason == string.Empty || oper == string.Empty || comment == string.Empty)
            {
                DialogResult result1 = MessageBox.Show("查询条件不能有空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtPlateLicense.Focus();
                }
            }
            else
            {
                DialogResult result2 = MessageBox.Show("确定要插入黑名单", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    string insert = $"insert into INVehicleBlacklist (VehicleNum,VSignReason,VSignTime,VOperator,VBComment) values ('{license}','{reason}','{date}','{oper}','{comment}')";
                    OleDbCommand cmd = new OleDbCommand(insert, database.dbConn);    // 执行SQL语句
                    cmd.ExecuteNonQuery();
                    DialogResult result3 = MessageBox.Show("插入成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result3 == DialogResult.OK)
                    {
                        txtPlateLicense.Focus();
                    }
                }
                else
                {
                    txtPlateLicense.Focus();
                }
            }

            database.dbConn.Close();
        }
    }
}
