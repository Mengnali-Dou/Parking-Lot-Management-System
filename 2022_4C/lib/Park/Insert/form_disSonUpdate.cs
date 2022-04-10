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
    public partial class form_disSonUpdate : Form
    {
        public uc_DisArea uc_Dis;
        public form_disSonUpdate(uc_DisArea uc_Dis)
        {
            this.uc_Dis = uc_Dis;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string PASystemNum = txtPASystemNum.Text;
            string PANum = txtPANum.Text;
            string PSystemNum = txtPSystemNum.Text;
            string comment = rtxtComment.Text;
            string update = null;

            if (PASystemNum == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入停车区系统编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPASystemNum.Focus();
                }
            }
            else
            {
                string sel = $"select * from PAParkingArea where PASystemNum = '{PASystemNum}'";
                OleDbDataAdapter inst1 = new OleDbDataAdapter(sel, database.dbConn);
                DataTable dt1 = new DataTable();
                inst1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    DialogResult dialog2 = MessageBox.Show("未查询到此编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtPASystemNum.Focus();
                    }
                }
                else
                {
                    if (PANum == string.Empty && PSystemNum == string.Empty && comment == string.Empty)
                    {
                        DialogResult dialog3 = MessageBox.Show("需要输入需要修改的内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog3 == DialogResult.OK)
                        {
                            txtPANum.Focus();
                        }
                    }
                    else
                    {
                        if (PANum != string.Empty && PSystemNum == string.Empty && comment == string.Empty)
                        {
                            update = $"update PAParking set PANum = '{PANum}' where PASystemNum = '{PASystemNum}'";
                        }
                        else if (PANum == string.Empty && PSystemNum != string.Empty && comment == string.Empty)
                        {
                            update = $"update PAParking set PSystemNum = '{PSystemNum}' where PASystemNum = '{PASystemNum}'";
                        }
                        else if (PANum == string.Empty && PSystemNum == string.Empty && comment != string.Empty)
                        {
                            update = $"update PAParking set PAComment = '{comment}' where PASystemNum = '{PASystemNum}'";
                        }
                        else if (PANum != string.Empty && PSystemNum != string.Empty && comment == string.Empty)
                        {
                            update = $"update PAParking set PANum = '{PANum}',PSystemNum = '{PSystemNum}' where PASystemNum = '{PASystemNum}'";
                        }
                        else if (PANum != string.Empty && PSystemNum == string.Empty && comment != string.Empty)
                        {
                            update = $"update PAParking set PANum = '{PANum}',PAComment = '{comment}' where PASystemNum = '{PASystemNum}'";
                        }
                        else if (PANum == string.Empty && PSystemNum != string.Empty && comment != string.Empty)
                        {
                            update = $"update PAParking set PAComment = '{comment},PSystemNum = '{PSystemNum}' where PASystemNum = '{PASystemNum}'";
                        }
                        else if (PANum == string.Empty && PSystemNum != string.Empty && comment != string.Empty)
                        {
                            update = $"update PAParking set PANum = '{PANum}',PSystemNum = '{PSystemNum}',PAComment = '{comment} where PASystemNum = '{PASystemNum}'";
                        }
                        OleDbCommand myCommand = new OleDbCommand(update, database.dbConn);
                        myCommand.ExecuteNonQuery();

                        string LOPANum = GenerateLOParkingAreaNum.generatle();
                        string date = DateTime.Now.ToShortDateString().ToString();
                        string even = $"修改停车区'{PASystemNum}'信息";
                        string insert = $"insert into LOParkingArea (LOPANum,LOPADate,LOPAEvent,LOPAAbnormal,LOPAComment) values ('{LOPANum}','{date}','{even}','否','')";
                        OleDbCommand cmd = new OleDbCommand(insert, database.dbConn);
                        cmd.ExecuteNonQuery();

                        DialogResult dialog4 = MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog4 == DialogResult.OK)
                        {
                            txtPANum.Focus();
                        }
                    }
                }
            }

            database.dbConn.Close();
        }

        private void form_disSonUpdate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
