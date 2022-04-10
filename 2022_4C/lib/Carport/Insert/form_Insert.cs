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

namespace _2022_4C.lib.Carport.Insert
{
    public partial class form_Insert : Form
    {
        public form_Insert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string park = txtPark.Text;
            string PANum = txtParkNum.Text;
            string type = combPSType.Text;
            int amount = Convert.ToInt32(numbers.Text);
            string comment = rtxtComment.Text;

            if (PANum == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("除备注外不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtParkNum.Focus();
                }
            }
            else
            {
                string select1 = $"select PASystemNum from PAParkingArea where PAnum = '{PANum}' and PSystemNum = '{park}'";
                OleDbDataAdapter inst1 = new OleDbDataAdapter(select1, database.dbConn);
                DataTable dt1 = new DataTable();
                inst1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    DialogResult dialog2 = MessageBox.Show("无此停车区", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtParkNum.Focus();
                    }
                }
                else
                {
                    for (int i = 1; i <= amount; i++)
                    {
                        string PSNum = GeneratelPAParkingSpot.num(PANum);
                        string PSSystemNum = GeneratelPAParkingSpot.system_num(park, PSNum);
                        string insert1 = $"insert into PAParkingSpot (PSSystemNum,PSNum,PANum,PSType,PSComment) values ('{PSSystemNum}','{PSNum}','{dt1.Rows[0]}','{type}','{comment}')";
                        OleDbCommand cmd1 = new OleDbCommand(insert1, database.dbConn);
                        cmd1.ExecuteNonQuery();

                        string LOPANum = GenerateLOParkingAreaNum.generatle();
                        string date = DateTime.Now.ToShortDateString().ToString();
                        string even = $"停车区'{dt1.Rows[0]}'添加'{amount}'个'{type}'";
                        string insert2 = $"insert into LOParkingArea (LOPANum,LOPADate,LOPAEvent,LOPAAbnormal,LOPAComment) values ('{LOPANum}','{date}','{even}','否','')";
                        OleDbCommand cmd2 = new OleDbCommand(insert2, database.dbConn);
                        cmd2.ExecuteNonQuery();

                        DialogResult dialog3 = MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog3 == DialogResult.OK)
                        {
                            txtParkNum.Focus();
                        }
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
