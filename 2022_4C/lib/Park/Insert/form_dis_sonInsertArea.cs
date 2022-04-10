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
    public partial class form_dis_sonInsertArea : Form
    {
        public form_dis_sonInsertArea()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string PASystemNum = null, PANum = null;
            string PSystemNum = txtNum.Text;
            string comment = rtxtComment.Text;

            if (PSystemNum == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入停车场系统编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
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
                    DialogResult dialog2 = MessageBox.Show("未查询到此停车场编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtNum.Focus();
                    }
                }
                else
                {
                    string select2 = $"select PANum from PAParking where PSystemNum = '{PSystemNum}'";
                    OleDbDataAdapter inst2 = new OleDbDataAdapter(select2, database.dbConn);
                    DataTable dt2 = new DataTable();
                    inst2.Fill(dt2);
                    int amount = dt2.Rows.Count;
                    if (amount >= 26)
                    {
                        DialogResult dialog3 = MessageBox.Show($"停车场'{PSystemNum}'停车区已达上限（26）", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog3 == DialogResult.OK)
                        {
                            txtNum.Focus();
                        }
                    }
                    else
                    {
                        PANum = GeneratePASystemNum.letter(amount);
                        PASystemNum = GeneratePASystemNum.PASystemNum(PANum, PSystemNum);
                        string insert = $"insert into PAParkingArea (PASystemNum,PANum,PSystemNum,PSComment) values ('{PASystemNum}','{PANum}','{PSystemNum}','{comment}')";
                        OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);
                        myCommand.ExecuteNonQuery();

                        string LOPANum = GenerateLOParkingAreaNum.generatle();
                        string date = DateTime.Now.ToShortDateString().ToString();
                        string even = $"停车场'{PSystemNum}'添加停车区'{PASystemNum}'";
                        string insert2 = $"insert into LOParkingArea (LOPANum,LOPADate,LOPAEvent,LOPAAbnormal,LOPAComment) values ('{LOPANum}','{date}','{even}','否','')";
                        OleDbCommand cmd = new OleDbCommand(insert2, database.dbConn);
                        cmd.ExecuteNonQuery();

                        DialogResult dialog4 = MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog4 == DialogResult.OK)
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
