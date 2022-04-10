using _2022_4C.data;
using _2022_4C.lib.TemVehicle.Enter.EnterExit;
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
    public partial class uc_Enter : UserControl
    {
        public uc_Enter()
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
                select = "select * from EEEnterArena";
            }
            else
            {
                select = $"select * from EEEnterArena where LicensePlateNum = '{num}'";
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "进场编号";
            dataGridView1.Columns[1].HeaderText = "车牌号（通行证号）";
            dataGridView1.Columns[2].HeaderText = "进场时间";
            dataGridView1.Columns[3].HeaderText = "备注";
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void uc_Enter_Load(object sender, EventArgs e)
        {
            string select = "select * from EEEnterArena";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "进场编号";
            dataGridView1.Columns[1].HeaderText = "车牌号（通行证号）";
            dataGridView1.Columns[2].HeaderText = "进场时间";
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
            string insert = null;
            string LOEENum = null;

            string select1 = $"select * from PAPark where PSystemNum = '{park}'";
            OleDbDataAdapter inst1 = new OleDbDataAdapter(select1, database.dbConn);
            DataTable dt1 = new DataTable();
            inst1.Fill(dt1);
            if (dt1.Rows.Count == 0)
            {
                DialogResult dialog1 = MessageBox.Show("无此停车场", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        // TODO:无牌车辆进场
                        form_unlicensedVehicleEnter form = new form_unlicensedVehicleEnter(park);
                        form.ShowDialog();
                    }
                    else
                    {
                        // 插入车辆进场表
                        string enter_num = GeneratelEnterNum.EnterNum(park);
                        string time = DateTime.Now.ToString();
                        insert = $"insert into EEEnterArena (EnterNum,LicensePlateNum,EnterTime,EnComment) vallues ('{enter_num}','{num}','{time}','')";
                        OleDbCommand cmd1 = new OleDbCommand(insert, database.dbConn);
                        cmd1.ExecuteNonQuery();

                        if (type == "临时车辆")
                        {
                            // 临时车辆订单
                            string OFTVNum = GeneratelOFTVNum.OFTVNum(park);    // 订单号
                            string dt = DateTime.Now.ToString();
                            string ins_OFTV = $"insert into OFTemporaryVehicle (OFTVNum,LincesePlateNum,EnterTime) values ('{OFTVNum}','{num}','{dt}')";
                            OleDbCommand cmd2 = new OleDbCommand(ins_OFTV, database.dbConn);
                            cmd2.ExecuteNonQuery();

                            // 插入车辆进出场记录
                            LOEENum = GeneratleLOEENum.LOEENum(park);
                            string ins_LOEE = $"insert into LOEnterExit (LOEENum,OrderFormNum,VehicleType,VehicleNum,EnterTime) values ('{LOEENum}','{OFTVNum}','{type}','{num}','{dt}')";
                            OleDbCommand cmd3 = new OleDbCommand(ins_LOEE, database.dbConn);
                            cmd3.ExecuteNonQuery();

                            // 临时车辆表
                            string select2 = $"select * from VETemporaryVehicle where LicensePlateNum = '{num}'";
                            OleDbDataAdapter inst2 = new OleDbDataAdapter(select2, database.dbConn);
                            DataTable dt2 = new DataTable();
                            inst2.Fill(dt2);
                            if (dt2.Rows.Count == 0)
                            {
                                string ins_VETV = $"insert into VETemporaryVehicle (LicensePlateNum,WtPO) values ('{num}','是')";
                                OleDbCommand cmd4 = new OleDbCommand(ins_VETV, database.dbConn);
                                cmd4.ExecuteNonQuery();
                            }
                            else
                            {
                                string update_VETE = $"update VETemporaryVehicle set WtPO = '是' where LicensePlateNum = '{num}'";
                                OleDbCommand cmd5 = new OleDbCommand(update_VETE, database.dbConn);
                                cmd5.ExecuteNonQuery();
                            }
                        }
                        else if (type == "固定车辆")
                        {
                            // 查找订单号
                            string select2 = $"select OFFVNum from OFFixedVehicle where LicensePlateNum = '{num}'";
                            OleDbDataAdapter inst2 = new OleDbDataAdapter(select2, database.dbConn);
                            DataTable dt2 = new DataTable();
                            inst2.Fill(dt2);
                            if (dt2.Rows.Count == 0)
                            {
                                DialogResult dialog1 = MessageBox.Show("无此固定车辆", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (dialog1 == DialogResult.OK)
                                {
                                    combType.Focus();
                                }
                            }
                            else
                            {
                                string OFFVNum = dt2.Rows[0].ToString();

                                // 插入车辆进出场记录
                                LOEENum = GeneratleLOEENum.LOEENum(park);
                                string dt = DateTime.Now.ToString();
                                string ins_LOEE = $"insert into LOEnterExit (LOEENum,OrderFormNum,VehicleType,VehicleNum,EnterTime) values ('{LOEENum}','{OFFVNum}','{type}','{num}','{dt}')";
                                OleDbCommand cmd3 = new OleDbCommand(ins_LOEE, database.dbConn);
                                cmd3.ExecuteNonQuery();

                                // 固定车辆表
                                string select3 = $"select * from VEFixedVehicle where LicensePlateNum = '{num}'";
                                OleDbDataAdapter inst3 = new OleDbDataAdapter(select3, database.dbConn);
                                DataTable dt3 = new DataTable();
                                inst3.Fill(dt3);
                                if (dt3.Rows.Count == 0)
                                {
                                    string ins_VETV = $"insert into VEFixedVehicle (LicensePlateNum,WtPO) values ('{num}','是')";
                                    OleDbCommand cmd4 = new OleDbCommand(ins_VETV, database.dbConn);
                                    cmd4.ExecuteNonQuery();
                                }
                                else
                                {
                                    string update_VETE = $"update VEFixedVehicle set WtPO = '是' where LicensePlateNum = '{num}'";
                                    OleDbCommand cmd5 = new OleDbCommand(update_VETE, database.dbConn);
                                    cmd5.ExecuteNonQuery();
                                }

                                // 闲时出租
                                string selRent = $"select * from IRRentOut where CarOwnerID = '{txtNum}'";
                                OleDbDataAdapter inst4 = new OleDbDataAdapter(selRent, database.dbConn);
                                DataTable dt4 = new DataTable();
                                inst4.Fill(dt4);

                                if (dt4.Rows.Count != 0)
                                {
                                    string backTime = DateTime.Now.ToString("HH:MM");
                                    string selOrderForm = $"select * from OFIdleRent where ParkingTime = ''";
                                    OleDbDataAdapter inst5 = new OleDbDataAdapter(selOrderForm, database.dbConn);
                                    DataTable dt5 = new DataTable();
                                    inst5.Fill(dt5);
                                    string leaveTime = dt5.Rows[0][2].ToString();
                                    string parkTime = (Convert.ToDateTime(backTime) - Convert.ToDateTime(leaveTime)).TotalHours.ToString();
                                    string cost = (Convert.ToInt32(parkTime) * 2).ToString();
                                    string updateOFIR = $"update OFIdleRent set EnterTime = '{backTime}',ParkingTime = '{parkTime}',Cost = '{cost}' where OFIRNum = '{dt5.Rows[0][0]}'";
                                    OleDbCommand cmd6 = new OleDbCommand(updateOFIR, database.dbConn);
                                    cmd6.ExecuteNonQuery();

                                    // 闲时出租日志
                                    string selLOIR = $"select * from LOIdleRent where ParkingVehicle = '{txtNum}' and ParkingTime = ''";
                                    OleDbDataAdapter inst6 = new OleDbDataAdapter(selOrderForm, database.dbConn);
                                    DataTable dt6 = new DataTable();
                                    inst6.Fill(dt6);
                                    string LOIRNum = dt6.Rows[0][0].ToString();
                                    string updateLOIR = $"update LOIdleRent set ParkingTime = '{backTime}' where LOIRNum = '{LOIRNum}'";
                                    OleDbCommand cmd7 = new OleDbCommand(updateLOIR, database.dbConn);
                                    cmd7.ExecuteNonQuery();

                                    // TODO:出租租金返还
                                    string ReNum = GenerateRENum.RENum(txtPark.Text);
                                    string selOwner = $"select * from VEFixedVehicle where LicensePlateNum = '{txtNum}'";
                                    OleDbDataAdapter inst7 = new OleDbDataAdapter(selOwner, database.dbConn);
                                    DataTable dt7 = new DataTable();
                                    inst7.Fill(dt7);
                                    string OwnerID = dt7.Rows[0][1].ToString();
                                    string parkSpot = dt7.Rows[0][3].ToString();

                                    string srlOperator = $"select ID from Cache where Num = 1";
                                    OleDbDataAdapter inst8 = new OleDbDataAdapter(srlOperator, database.dbConn);
                                    DataTable dt8 = new DataTable();
                                    inst8.Fill(dt8);
                                    string oper = dt8.Rows[0][0].ToString();

                                    string insertFIRR = $"insert into FIReturnRent (ReNum,ReTime,ReSum,ReOwnerID,ReParking,ChargeOperator) values ('{ReNum}','{time}','{cost}','{OwnerID}','{parkSpot}','{oper}')";
                                    OleDbCommand cmd8 = new OleDbCommand(insertFIRR, database.dbConn);
                                    cmd8.ExecuteNonQuery();

                                    // TODO:支出
                                    string DisNum = GenerateDisNum.DisNum(park);

                                    string insertFIDis = $"insert into FIDisbursement (DisNum,DisTime,DisProject,DisSum,ChargeOperator) values ('{DisNum}','{time}','闲时出租租金返还','{cost}','{oper}')";
                                    OleDbCommand cmd9 = new OleDbCommand(insertFIDis, database.dbConn);
                                    cmd9.ExecuteNonQuery();
                                }
                            }  
                        }
                        else
                        {
                            // TODO:特殊车辆进场
                            // 特殊车辆进场订单
                            string OFSVNum = GenerateOFSVNum.OFSVNum(park);    // 订单号
                            string dt = DateTime.Now.ToString();
                            string ins_OFSV = $"insert into OFTemporaryVehicle (OFTVNum,LincesePlateNum,EnterTime) values ('{OFSVNum}','{num}','{dt}')";
                            OleDbCommand cmd2 = new OleDbCommand(ins_OFSV, database.dbConn);
                            cmd2.ExecuteNonQuery();

                            // 插入车辆进出场记录
                            LOEENum = GeneratleLOEENum.LOEENum(park);
                            string ins_LOEE = $"insert into LOEnterExit (LOEENum,OrderFormNum,VehicleType,VehicleNum,EnterTime) values ('{LOEENum}','{OFSVNum}','{type}','{num}','{dt}')";
                            OleDbCommand cmd3 = new OleDbCommand(ins_LOEE, database.dbConn);
                            cmd3.ExecuteNonQuery();

                            // 特殊车辆表
                            string select2 = $"select * from VESpecialVehicle where LicensePlateNum = '{num}'";
                            OleDbDataAdapter inst2 = new OleDbDataAdapter(select2, database.dbConn);
                            DataTable dt2 = new DataTable();
                            inst2.Fill(dt2);
                            if (dt2.Rows.Count == 0)
                            {
                                string ins_VETV = $"insert into VESpecialVehicle (LicensePlateNum,WtPO) values ('{num}','是')";
                                OleDbCommand cmd4 = new OleDbCommand(ins_VETV, database.dbConn);
                                cmd4.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            database.dbConn.Close();
        }
    }
}
