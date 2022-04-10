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

namespace _2022_4C.lib.Park.Insert
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

            string num = txtPark.Text;
            string name = txtParkingSpot.Text;
            string comment = rtxtComment.Text;

            if (num == string.Empty && name == string.Empty)
            {
                DialogResult dialog2 = MessageBox.Show("除备注外不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog2 == DialogResult.OK)
                {
                    txtPark.Focus();
                }
            }
            else
            {
                string select_1 = $"select * from PAPark where PSystemNum = '{num}'";
                OleDbDataAdapter inst_1 = new OleDbDataAdapter(select_1, database.dbConn);
                DataSet ds_1 = new DataSet();
                inst_1.Fill(ds_1);
                if (ds_1.Tables[0].Rows.Count != 0)
                {
                    DialogResult dialog2 = MessageBox.Show("系统编号重复", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtPark.Focus();
                    }
                }
                else
                {
                    string select_2 = $"select * from PAPark where PSystemNum = '{num}'";
                    OleDbDataAdapter inst_2 = new OleDbDataAdapter(select_2, database.dbConn);
                    DataSet ds_2 = new DataSet();
                    inst_2.Fill(ds_2);
                    if (ds_2.Tables[0].Rows.Count != 0)
                    {
                        DialogResult dialog3 = MessageBox.Show("停车场名重复", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog3 == DialogResult.OK)
                        {
                            txtParkingSpot.Focus();
                        }
                    }
                    else
                    {
                        string insert = $"insert into PAPark (PSystemNum,PName,PComment) values ('{num}','{name}','{comment}')";
                        OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);
                        myCommand.ExecuteNonQuery();

                        string LOPNum = GenerateLOParkNum.generate();

                        string date = DateTime.Now.ToShortDateString().ToString();
                        string insert_2 = $"insert into LOPark (LOPNum,LOPDate,LOPEvent,LOPAbnormal,LOPComment) values ('{LOPNum}','{date}','新增停车场','否','{comment}')";
                        OleDbCommand myCommand_2 = new OleDbCommand(insert_2, database.dbConn);    // 执行SQL语句
                        myCommand_2.ExecuteNonQuery();
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
