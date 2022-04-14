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
    public partial class form_RentOut : Form
    {
        public form_RentOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string park = this.txtPark.Text;
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
                    string selPark = $"select * from PAPark where PSystemNum = '{park}'";
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
                            string selOwnerID = $"select LicensePlateNum from VEFixedVehicle where ParkingSpot = '{dt3.Rows[0][0].ToString()}'";
                            OleDbDataAdapter cmd4 = new OleDbDataAdapter(selOwnerID, database.dbConn);
                            DataTable dt4 = new DataTable();
                            cmd4.Fill(dt4);

                            labID.Text = dt4.Rows[0][0].ToString();

                            string selBeginTime = $"select BeginTime,EndTime from IRRentOut where StallSystemNum = '{dt3.Rows[0][0].ToString()}'";
                            OleDbDataAdapter cmd5 = new OleDbDataAdapter(selBeginTime, database.dbConn);
                            DataTable dt5 = new DataTable();
                            cmd5.Fill(dt5);

                            if (dt5.Rows.Count != 0)
                            {
                                combBeginTime.Text = dt5.Rows[0][0].ToString();
                                combEndTime.Text = dt5.Rows[0][1].ToString();
                            }
                        }
                    }
                }
            }

            database.dbConn.Close();
        }

        private void form_RentOut_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string park = txtPark.Text;
            string parkingSpot = txtParkingSpot.Text;
            string beginTime = combBeginTime.Text;
            string endTime = combEndTime.Text;

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
                            string selOwnerID = $"select LicensePlateNum from VEFixedVehicle where ParkingSpot = '{dt3.Rows[0][0].ToString()}'";
                            OleDbDataAdapter cmd4 = new OleDbDataAdapter(selOwnerID, database.dbConn);
                            DataTable dt4 = new DataTable();
                            cmd4.Fill(dt4);

                            string selBeginTime = $"select BeginTime,EndTime from IRRentOut where StallSystemNum = '{dt3.Rows[0][0].ToString()}'";
                            OleDbDataAdapter cmd5 = new OleDbDataAdapter(selBeginTime, database.dbConn);
                            DataTable dt5 = new DataTable();
                            cmd5.Fill(dt5);

                            if (dt5.Rows.Count == 0)
                            {
                                string insert = $"insert into IRRentOut (StallSystemNum,CarOwnerID,BeginTime,EndTime) values ('{dt3.Rows[0][0].ToString()}','{dt4.Rows[0][0].ToString()}','{beginTime}','{endTime}')";
                                OleDbCommand inst1 = new OleDbCommand(insert, database.dbConn);
                                inst1.ExecuteNonQuery();
                            }
                            else
                            {
                                string update = $"update IRRentOut set StallSystemNum = '{dt3.Rows[0][0]}',CarOwnerID = '{dt4.Rows[0][0].ToString()}',BeginTime = '{beginTime}',EndTime = '{endTime}'";
                                OleDbCommand inst2 = new OleDbCommand(update, database.dbConn);
                                inst2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
