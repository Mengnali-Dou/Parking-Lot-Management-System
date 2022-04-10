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

namespace _2022_4C.lib.TemVehicle.Enter
{
    public partial class uc_Exit : UserControl
    {
        public uc_Exit()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLicensePlateNum.Text;
            string select = null;

            if (num == string.Empty)
            {
                select = "select * from EEExitArena";
            }
            else
            {
                select = $"select * from EEExitArena where LicensePlateNum = '{num}'";
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "出场编号";
            dataGridView1.Columns[1].HeaderText = "车牌号（通行证号）";
            dataGridView1.Columns[2].HeaderText = "出场时间";
            dataGridView1.Columns[3].HeaderText = "备注";
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void uc_Exit_Load(object sender, EventArgs e)
        {
            string select = "select * from EEExitArena";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "出场编号";
            dataGridView1.Columns[1].HeaderText = "车牌号（通行证号）";
            dataGridView1.Columns[2].HeaderText = "出场时间";
            dataGridView1.Columns[3].HeaderText = "备注";
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string park = txtPark.Text;
            string num = txtNum.Text;
            string type = combType.Text;

            if (park == string.Empty || num == string.Empty || type == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("条件不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    combType.Focus();
                }
            }
            else
            {
                string select = $"select * from LOEnterExit where VehicleNum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog = MessageBox.Show("无此停车场", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        combType.Focus();
                    }
                }
                else
                {
                    string select1 = $"select * from PAPark where PSystemNum = '{park}'";
                    OleDbDataAdapter inst1 = new OleDbDataAdapter(select1, database.dbConn);
                    DataTable dt1 = new DataTable();
                    inst1.Fill(dt1);
                    if (dt1.Rows.Count == 0)
                    {
                        DialogResult dialog1 = MessageBox.Show("无此车辆", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog1 == DialogResult.OK)
                        {
                            combType.Focus();
                        }
                    }
                    else
                    {

                        if (type == string.Empty)
                        {
                            DialogResult dialog2 = MessageBox.Show("请选择车辆类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog2 == DialogResult.OK)
                            {
                                combType.Focus();
                            }
                        }
                        else
                        {
                            if (type == "无牌车辆")
                            {
                                string time = DateTime.Now.ToString();
                                string select_EnterTime = $"select EnterTime from OFUnlicensedVehicle where LicensePlateNum = '{num}'";
                                OleDbDataAdapter inst2 = new OleDbDataAdapter(select_EnterTime, database.dbConn);
                                DataTable dt2 = new DataTable();
                                inst2.Fill(dt2);
                                string enterTime = dt2.Rows[0][0].ToString();    // 获取进场时间
                                string parkingTime = (Convert.ToDateTime(time) - Convert.ToDateTime(enterTime)).ToString();    // 停车时长

                                // 车辆出场
                                string enter_num = GenerateExitNum.ExitNum(park);
                                string insert = $"insert into EEEnterArena (EnterNum,LicensePlateNum,EnterTime,EnComment) vallues ('{enter_num}','{num}','{time}','')";
                                OleDbCommand cmd1 = new OleDbCommand(insert, database.dbConn);
                                cmd1.ExecuteNonQuery();

                                // 无牌车辆表
                                string update_VEUV = $"update VEUnlicensedVehicle set WtPO = '否' where LicensePlateNum = '{num}'";
                                OleDbCommand cmd2 = new OleDbCommand(update_VEUV, database.dbConn);
                                cmd2.ExecuteNonQuery();

                                // 车辆进出场记录
                                string update_LOEE = $"update LOEnterExit set ExitTime = '{time}',ParkingTime = '{parkingTime}' where LicensePlateNum = '{num}' and ExitTime = ''";
                                OleDbCommand cmd3 = new OleDbCommand(update_LOEE, database.dbConn);
                                cmd3.ExecuteNonQuery();

                                // 订单
                                string select_OFUV = $"select OFUVNum from OFTUnlicensedVehicle where LicensePlateNum = '{num}' and ExitTime = ''";
                                OleDbDataAdapter inst4 = new OleDbDataAdapter(select_OFUV, database.dbConn);
                                DataTable dt4 = new DataTable();
                                inst4.Fill(dt4);
                                string OFUVNum = dt4.Rows[0][0].ToString();
                                string update_OFUV = $"update OFTUnlicensedVehicle set ExitTime = '{time}',ParkingTime = '{parkingTime}' where LicensePlateNum = '{num}' and ExitTime = ''";
                                OleDbCommand cmd4 = new OleDbCommand(update_OFUV, database.dbConn);
                                cmd4.ExecuteNonQuery();

                                // 收费
                                string chargeNum = GenerateChargeNum.ChargeNum(park);
                                string select_rateNum = "select Cost from FIRates where RateNum = 'SX001'";
                                OleDbDataAdapter inst3 = new OleDbDataAdapter(select_rateNum, database.dbConn);
                                DataTable dt3 = new DataTable();
                                inst3.Fill(dt3);
                                string sum = dt3.Rows[0][0].ToString();
                                string cost = (Convert.ToDateTime(parkingTime).Hour * Convert.ToInt32(sum)).ToString();
                                string insert_chargeNum = $"insert into FIVehicleCharge (ChargeNum,ChargeTime,Cost,OFNum) values ('{chargeNum}','{time}','{cost}','{OFUVNum}')";
                                OleDbCommand cmd5 = new OleDbCommand(insert_chargeNum, database.dbConn);
                                cmd5.ExecuteNonQuery();
                            }
                            else
                            {
                                // 车辆出场
                                string enter_num = GenerateExitNum.ExitNum(park);
                                string time = DateTime.Now.ToString();
                                string insert = $"insert into EEEnterArena (EnterNum,LicensePlateNum,EnterTime,EnComment) vallues ('{enter_num}','{num}','{time}','')";
                                OleDbCommand cmd1 = new OleDbCommand(insert, database.dbConn);
                                cmd1.ExecuteNonQuery();

                                if (type == "临时车辆")
                                {
                                    string select_EnterTime = $"select EnterTime from OFTemporaryVehicle where LicensePlateNum = '{num}'";
                                    OleDbDataAdapter inst2 = new OleDbDataAdapter(select_EnterTime, database.dbConn);
                                    DataTable dt2 = new DataTable();
                                    inst2.Fill(dt2);
                                    string enterTime = dt2.Rows[0][0].ToString();    // 获取进场时间
                                    string parkingTime = (Convert.ToDateTime(time) - Convert.ToDateTime(enterTime)).ToString();    // 停车时长

                                    // 临时车辆订单
                                    string select_OFTV = $"select OFTVNum from OFTemporaryVehicle where LicensePlateNum = '{num}' and ExitTime = ''";
                                    OleDbDataAdapter inst4 = new OleDbDataAdapter(select_OFTV, database.dbConn);
                                    DataTable dt4 = new DataTable();
                                    inst4.Fill(dt4);
                                    string OFTVNum = dt4.Rows[0][0].ToString();
                                    string update_OFTV = $"update OFTemporaryVehicle set ExitTime = '{time}',ParkingTime = '{parkingTime}' where LicensePlateNum = '{num}' and ExitTime = ''";
                                    OleDbCommand cmd2 = new OleDbCommand(update_OFTV, database.dbConn);
                                    cmd2.ExecuteNonQuery();

                                    // 临时车辆表
                                    string update_VETV = $"update VETenporaryVehicle set WtPO = '否' where LicensePlateNum = '{num}'";
                                    OleDbCommand cmd3 = new OleDbCommand(update_VETV, database.dbConn);
                                    cmd3.ExecuteNonQuery();

                                    // 车辆进出场记录
                                    string update_LOEE = $"update LOEnterExit set ExitTime = '{time}',ParkingTime = '{parkingTime}' where LicensePlateNum = '{num}' and ExitTime = ''";
                                    OleDbCommand cmd4 = new OleDbCommand(update_LOEE, database.dbConn);
                                    cmd4.ExecuteNonQuery();

                                    // 车辆收费
                                    string chargeNum = GenerateChargeNum.ChargeNum(park);
                                    string select_rateNum = "select Cost from FIRates where RateNum = 'SX001'";
                                    OleDbDataAdapter inst3 = new OleDbDataAdapter(select_rateNum, database.dbConn);
                                    DataTable dt3 = new DataTable();
                                    inst3.Fill(dt3);
                                    string sum = dt3.Rows[0][0].ToString();
                                    string cost = (Convert.ToDateTime(parkingTime).Hour * Convert.ToInt32(sum)).ToString();
                                    string insert_chargeNum = $"insert into FIVehicleCharge (ChargeNum,ChargeTime,Cost,OFNum) values ('{chargeNum}','{time}','{cost}','{OFTVNum}')";
                                    OleDbCommand cmd5 = new OleDbCommand(insert_chargeNum, database.dbConn);
                                    cmd5.ExecuteNonQuery();
                                }
                                else if (type == "固定车辆")
                                {
                                    // 固定车辆表
                                    string update_VEFV = $"update VEFixedVehicle set WtPO = '否' where LicensePlateNum = '{num}'";
                                    OleDbCommand cmd2 = new OleDbCommand(update_VEFV, database.dbConn);
                                    cmd2.ExecuteNonQuery();

                                    // 获取停车时长
                                    string select_EnterTime = $"select EnterTime from LOEnterExit where VehicleNum = '{num}'";
                                    OleDbDataAdapter inst2 = new OleDbDataAdapter(select_EnterTime, database.dbConn);
                                    DataTable dt2 = new DataTable();
                                    inst2.Fill(dt2);
                                    string enterTime = dt2.Rows[0][0].ToString();
                                    string parkingTime = (Convert.ToDateTime(time) - Convert.ToDateTime(enterTime)).ToString();

                                    // 车辆进出场记录
                                    string update_LOEE = $"update LOEnterExit set ExitTime = '{time}',ParkingTime = '{parkingTime}' where LicensePlateNum = '{num}' and ExitTime = ''";
                                    OleDbCommand cmd3 = new OleDbCommand(update_LOEE, database.dbConn);
                                    cmd3.ExecuteNonQuery();

                                    // 闲时出租订单
                                    string selRent = $"select * from IRRentOut where CarOwnerID = '{txtNum}'";
                                    OleDbDataAdapter inst3 = new OleDbDataAdapter(selRent, database.dbConn);
                                    DataTable dt3 = new DataTable();
                                    inst3.Fill(dt3);
                                    if (dt3.Rows.Count != 0)
                                    {
                                        string leaveTime = DateTime.Now.ToString("HH:MM");
                                        string OFIRNum = GenerateOFIRNum.OFIRNum(park);
                                        string parkingSpot = dt3.Rows[0][0].ToString();
                                        string insertIdle = null;
                                        int i = leaveTime.CompareTo(dt3.Rows[0][2]);
                                        if (i <= 0)
                                        {
                                            insertIdle = $"insert into OFIdleRent (OFIRNum,PSSystemNum,ExitTime) values ('{OFIRNum}','{parkingSpot}','{dt3.Rows[0][2]}')";
                                        }
                                        else
                                        {
                                            insertIdle = $"insert into OFIdleRent (OFIRNum,PSSystemNum,ExitTime) values ('{OFIRNum}','{parkingSpot}','{leaveTime}')";
                                        }
                                        OleDbCommand cmd4 = new OleDbCommand(insertIdle, database.dbConn);
                                        cmd4.ExecuteNonQuery();

                                        // 闲时出租日志
                                        string LOIRNum = GenerateLOIRNum.LOIRNum();
                                        string insertLOIR = $"insert into LOIdleRent (LOIRNum,PSSystemNum,ParkingVehicle,LeaveTime) values ('{LOIRNum}','{parkingSpot}','{txtNum}','{leaveTime}')";
                                        OleDbCommand cmd5 = new OleDbCommand(insertLOIR, database.dbConn);
                                        cmd5.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // 车辆进出场记录
                                    string update_LOEE = $"update LOEnterExit set ExitTime = '{time}',ParkingTime = '--' where LicensePlateNum = '{num}' and ExitTime = ''";
                                    OleDbCommand cmd3 = new OleDbCommand(update_LOEE, database.dbConn);
                                    cmd3.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
