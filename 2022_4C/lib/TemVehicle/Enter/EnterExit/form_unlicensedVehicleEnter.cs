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

namespace _2022_4C.lib.TemVehicle.Enter.EnterExit
{
    public partial class form_unlicensedVehicleEnter : Form
    {
        public form_unlicensedVehicleEnter(string park)
        {
            InitializeComponent();
            parkNum = park;
        }

        string parkNum;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string sex = null;
            string tel = txtTel.Text;

            if (rbtnMale.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            // TODO:添加无牌车辆车主
            string id = GenerateUVOwnerID.UVOwnerID();
            string insert_owner = $"insert into VOUnlicensedVehicle (UVOwnerID,UVOwnerName,UVOwnerSex,UVOwnerTel) values ('{id}','{name}','{sex}','{tel}')";
            OleDbCommand cmd1 = new OleDbCommand(insert_owner, database.dbConn);
            cmd1.ExecuteNonQuery();

            // TODO:车辆进场。。。
            string LicensePlateNum = GenetrateLicensePlateNum.LicensePlateNum(id);
            string insert_Unlicense = $"insert into VEUnlicensedVehicle (LicensePlateNum,CarOwnerID,WtPO) values ('{LicensePlateNum}','{id}','是')";
            OleDbCommand cmd2 = new OleDbCommand(insert_owner, database.dbConn);
            cmd2.ExecuteNonQuery();

            // 车辆进场
            string enter_num = GeneratelEnterNum.EnterNum(parkNum);
            string time = DateTime.Now.ToString();
            string insert = $"insert into EEEnterArena (EnterNum,LicensePlateNum,EnterTime,EnComment) vallues ('{enter_num}','{LicensePlateNum}','{time}','')";
            OleDbCommand cmd3 = new OleDbCommand(insert, database.dbConn);
            cmd3.ExecuteNonQuery();

            // 订单
            string OFUVNum = GenerateOFUVNum.OFUVNum(parkNum);    // 订单号
            string dt = DateTime.Now.ToString();
            string ins_OFTV = $"insert into OFUnlicensedVehicle (OFUVNum,VehicleNum,EnterTime) values ('{OFUVNum}','{LicensePlateNum}','{dt}')";
            OleDbCommand cmd4 = new OleDbCommand(ins_OFTV, database.dbConn);
            cmd4.ExecuteNonQuery();

            // 进出场
            string LOEENum = GeneratleLOEENum.LOEENum(parkNum);
            string ins_LOEE = $"insert into LOEnterExit (LOEENum,OrderFormNum,VehicleType,VehicleNum,EnterTime) values ('{LOEENum}','{OFUVNum}','无牌车辆','{LicensePlateNum}','{DateTime.Now.ToString()}')";
            OleDbCommand cmd5 = new OleDbCommand(ins_LOEE, database.dbConn);
            cmd5.ExecuteNonQuery();

            DialogResult dialog1 = MessageBox.Show("完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog1 == DialogResult.OK)
            {
                
            }
        }
    }
}
