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

namespace _2022_4C.lib.Statement
{
    public partial class uc_sonTemporaryVehicle : UserControl
    {
        public uc_sonTemporaryVehicle()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string comment = rtxtComment.Text;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入订单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtLONum.Focus();
                }
            }
            else
            {
                string select = $"select * from OFTemporaryVehicle where OFTVNum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog1 = MessageBox.Show("未查询到此订单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog1 == DialogResult.OK)
                    {
                        txtLONum.Focus();
                    }
                }
                else
                {
                    string update = $"update OFTemporaryVehicle set OFTVComment = '{comment}' where OFTVNum = '{num}'";
                    OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                    cmd.ExecuteNonQuery();
                }
            }

            database.dbConn.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string comment = null;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入订单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtLONum.Focus();
                }
            }
            else
            {
                string select = $"select * from OFTemporaryVehicle where OFTVNum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog1 = MessageBox.Show("未查询到此订单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog1 == DialogResult.OK)
                    {
                        txtLONum.Focus();
                    }
                }
                else
                {
                    string sel = $"select OFTVComment from OFTemporaryVehicle where OFTVNum = '{num}'";
                    OleDbDataAdapter inst_sel = new OleDbDataAdapter(sel, database.dbConn);
                    DataTable dt_sel = new DataTable();
                    inst_sel.Fill(dt_sel);
                    rtxtComment.Text = dt_sel.Rows[0][0].ToString();
                }
            }

            database.dbConn.Close();
        }
    }
}
