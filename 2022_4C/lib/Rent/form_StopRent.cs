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

namespace _2022_4C.lib.Rent
{
    public partial class form_StopRent : Form
    {
        public form_StopRent()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string park = txtPark.Text;
            string parkingSpot = txtParkingSpot.Text;

            if (park == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("停车场不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPark.Focus();
                }
            }
            else
            {
                if (parkingSpot == string.Empty)
                {
                    DialogResult dialog2 = MessageBox.Show("停车位不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtParkingSpot.Focus();
                    }
                }
                else
                {
                    string selPark = $"select * from Park where PSystemNum = '{park}'";
                    OleDbDataAdapter cmd1 = new OleDbDataAdapter(selPark, database.dbConn);
                    DataTable dt1 = new DataTable();
                    cmd1.Fill(dt1);

                    if (dt1.Rows.Count == 0)
                    {
                        DialogResult dialog3 = MessageBox.Show("停车场编号错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog3 == DialogResult.OK)
                        {
                            txtPark.Focus();
                        }
                    }
                    else
                    {
                        string selParkingArea = $"select PASystemNum from PAParkingArea where PSystemNum = '{park}'";
                        OleDbDataAdapter cmd2 = new OleDbDataAdapter(selParkingArea, database.dbConn);
                        DataTable dt2 = new DataTable();
                        cmd2.Fill(dt2);
                        string selParkingSpot = $"select PSSystemNum from PAParkingSpot where PANum = '{dt2.Rows[0][0].ToString()}' and PSNum = '{parkingSpot}'";
                        OleDbDataAdapter cmd3 = new OleDbDataAdapter(selParkingSpot, database.dbConn);
                        DataTable dt3 = new DataTable();
                        cmd3.Fill(dt3);

                        if (dt3.Rows.Count == 0)
                        {
                            DialogResult dialog4 = MessageBox.Show("无此停车位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog4 == DialogResult.OK)
                            {
                                txtParkingSpot.Focus();
                            }
                        }
                        else
                        {
                            string sel = $"select * from IRRentOut where StallSystemNum = '{dt3.Rows[0][0].ToString()}'";
                            OleDbDataAdapter cmd4 = new OleDbDataAdapter(sel, database.dbConn);
                            DataTable dt4 = new DataTable();
                            cmd4.Fill(dt4);

                            if (dt4.Rows.Count == 0)
                            {
                                DialogResult dialog5 = MessageBox.Show("该停车位未办理闲时出租", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (dialog5 == DialogResult.OK)
                                {
                                    txtParkingSpot.Focus();
                                }
                            }
                            else
                            {
                                string delete = $"delete IRRentOut where StallSystemNum = '{dt3.Rows[0][0].ToString()}'";
                                OleDbCommand inst1 = new OleDbCommand(delete, database.dbConn);
                                inst1.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
