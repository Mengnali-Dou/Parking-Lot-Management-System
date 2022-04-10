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

namespace _2022_4C.lib.Statement
{
    public partial class uc_sonOrderForm : UserControl
    {
        public uc_sonTemporaryVehicle uc_TV;
        public uc_sonFixedVehicle uc_FV;
        public uc_sonUnlicensedVehicle uc_UV;
        public uc_sonSpecialVehicle uc_SV;
        public uc_sonIdleVehicle uc_IV;

        public uc_sonOrderForm()
        {
            InitializeComponent();
            uc_TV = new uc_sonTemporaryVehicle();
            uc_FV = new uc_sonFixedVehicle();
            uc_UV = new uc_sonUnlicensedVehicle();
            uc_SV = new uc_sonSpecialVehicle();
            uc_IV = new uc_sonIdleVehicle();
        }

        private void btnTemporaryVehicle_Click(object sender, EventArgs e)
        {
            uc_TV.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_TV);
            
            database.dbConn.Open();

            string select = "select * from OFTemporaryVehicle";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "车牌号";
            dataGridView1.Columns[2].HeaderText = "进场时间";
            dataGridView1.Columns[3].HeaderText = "出场时间";
            dataGridView1.Columns[4].HeaderText = "停车时间";
            dataGridView1.Columns[5].HeaderText = "停车位系统编号";
            dataGridView1.Columns[6].HeaderText = "备注";
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnFixedVehicle_Click(object sender, EventArgs e)
        {
            uc_FV.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_FV);

            database.dbConn.Open();

            string select = "select * from OFFixedVehicle";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "车牌号";
            dataGridView1.Columns[2].HeaderText = "充值时间";
            dataGridView1.Columns[3].HeaderText = "充值时长";
            dataGridView1.Columns[4].HeaderText = "到期时间";
            dataGridView1.Columns[5].HeaderText = "停车位系统编号";
            dataGridView1.Columns[6].HeaderText = "备注";
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnUnlicensedVehicel_Click(object sender, EventArgs e)
        {
            uc_UV.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_UV);

            database.dbConn.Open();

            string select = "select * from OFUnlicensedVehicle";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "通行证号";
            dataGridView1.Columns[2].HeaderText = "进场时间";
            dataGridView1.Columns[3].HeaderText = "出场时间";
            dataGridView1.Columns[4].HeaderText = "停车时间";
            dataGridView1.Columns[5].HeaderText = "停车位系统编号";
            dataGridView1.Columns[6].HeaderText = "备注";
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnSpecialVehicle_Click(object sender, EventArgs e)
        {
            uc_SV.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_SV);

            database.dbConn.Open();

            string select = "select * from OFSpecialVehicle";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "车牌号";
            dataGridView1.Columns[2].HeaderText = "进场时间";
            dataGridView1.Columns[3].HeaderText = "出场时间";
            dataGridView1.Columns[4].HeaderText = "停车时间";
            dataGridView1.Columns[5].HeaderText = "备注";
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnIdleVehicle_Click(object sender, EventArgs e)
        {
            uc_IV.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_IV);

            database.dbConn.Open();

            string select = "select * from OFIdleRent";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "车位系统编号";
            dataGridView1.Columns[2].HeaderText = "进场时间";
            dataGridView1.Columns[3].HeaderText = "出场时间";
            dataGridView1.Columns[4].HeaderText = "停车时长";
            dataGridView1.Columns[5].HeaderText = "费用";
            dataGridView1.Columns[6].HeaderText = "备注";
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }
    }
}
