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
    public partial class form_InsertArea : Form
    {
        public form_InsertArea()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string PSystemNum = txtNum.Text;
            int amount = int.Parse(numbers.Text.ToString());
            string comment = richTextBox1.Text;

            if (PSystemNum == string.Empty)
            {
                DialogResult dialog = MessageBox.Show("请输入停车场编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtNum.Focus();
                }
            }
            else
            {
                string select1 = $"select * from PAPark where PSystemNum = '{PSystemNum}'";
                OleDbDataAdapter inst1 = new OleDbDataAdapter(select1, database.dbConn);
                DataTable dt1 = new DataTable();
                inst1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    DialogResult dialog1 = MessageBox.Show("无此停车场", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog1 == DialogResult.OK)
                    {
                        txtNum.Focus();
                    }
                }
                else
                {
                    string select2 = $"select * from PAParkingArea where PSystemNum = '{PSystemNum}'";
                    OleDbDataAdapter inst2 = new OleDbDataAdapter(select2, database.dbConn);
                    DataTable dt2 = new DataTable();
                    inst2.Fill(dt2);
                    if (dt2.Rows.Count != 0)
                    {
                        DialogResult dialog2 = MessageBox.Show("该停车场已分区", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog2 == DialogResult.OK)
                        {
                            txtNum.Focus();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            string PANum = GeneratePASystemNum.letter(i);
                            string PASystemNum = GeneratePASystemNum.PASystemNum(PANum, PSystemNum);
                            string insert = $"insert into PAParking (PASystemNum,PANum,PSystemNum,PAComment) values ('{PASystemNum}','{PANum}','{PSystemNum}','{comment}')";
                            OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);
                            myCommand.ExecuteNonQuery();
                        }
                        DialogResult dialog3 = MessageBox.Show("划分完成", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog3 == DialogResult.OK)
                        {
                            txtNum.Focus();
                        }
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
