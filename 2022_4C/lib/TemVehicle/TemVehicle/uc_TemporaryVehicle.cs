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

namespace _2022_4C.lib.TemVehicle.TemVehicle
{
    public partial class uc_TemporaryVehicle : UserControl
    {
        public uc_TemporaryVehicle()
        {
            InitializeComponent();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select LicensePlateNum,WtPO from VETemporaryVehicle where WtPO = '是'";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "车牌号";
            dataGridView1.Columns[1].HeaderText = "是否在场";

            database.dbConn.Close();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select OFTVNum,LicensePlateNum,EnterTime,ExitTime,ParkingTime from OFTemporaryVehicle";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "车牌号";
            dataGridView1.Columns[2].HeaderText = "进场时间";
            dataGridView1.Columns[3].HeaderText = "出场时间";
            dataGridView1.Columns[4].HeaderText = "停车时长";

            database.dbConn.Close();
        }
    }
}
