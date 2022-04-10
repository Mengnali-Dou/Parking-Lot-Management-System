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

namespace _2022_4C.lib.TemVehicle.UnVehicle
{
    public partial class uc_UnlicensedVehicle : UserControl
    {
        public uc_UnlicensedVehicle()
        {
            InitializeComponent();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select LicensePlateNum,CarOwnerID,WtPO from VEUnlicensedVehicle where WtPO = '是'";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "通行证号";
            dataGridView1.Columns[1].HeaderText = "车主ID";
            dataGridView1.Columns[2].HeaderText = "是否在场";

            database.dbConn.Close();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select OFUVNum,VehicleNum,EnterTime,ExitTime,ParkingTime from OFUnlicensedVehicle";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "通行证号";
            dataGridView1.Columns[2].HeaderText = "进场时间";
            dataGridView1.Columns[3].HeaderText = "出场时间";
            dataGridView1.Columns[4].HeaderText = "停车时长";

            database.dbConn.Close();
        }
    }
}
