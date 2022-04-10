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

namespace _2022_4C.lib.TemVehicle.FixVehicle
{
    public partial class uc_FixedVehicle : UserControl
    {
        public uc_sonOrderForm uc_OF;

        public uc_FixedVehicle()
        {
            InitializeComponent();
            uc_OF = new uc_sonOrderForm();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            database.dbConn.Open();

            string select = "select * from VOFixedVehicle";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "车主ID";
            dataGridView1.Columns[1].HeaderText = "车主姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "联系电话";
            dataGridView1.Columns[4].HeaderText = "注册时间";
            dataGridView1.Columns[5].HeaderText = "备注";

            database.dbConn.Close();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            database.dbConn.Open();

            string select = "select * from VEFixedVehicle where WtPO = '是'";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "车牌号";
            dataGridView1.Columns[1].HeaderText = "车主ID";
            dataGridView1.Columns[2].HeaderText = "是否在场";
            dataGridView1.Columns[3].HeaderText = "停车位";
            dataGridView1.Columns[4].HeaderText = "备注";

            database.dbConn.Close();
        }

        private void btnFixedVehicle_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            database.dbConn.Open();

            string select = "select * from VEFixedVehicle";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "车牌号";
            dataGridView1.Columns[1].HeaderText = "车主ID";
            dataGridView1.Columns[2].HeaderText = "是否在场";
            dataGridView1.Columns[3].HeaderText = "停车位";
            dataGridView1.Columns[4].HeaderText = "备注";

            database.dbConn.Close();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            uc_OF.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_OF);

            database.dbConn.Open();

            string select = "select * from OFFixedVehicle";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "车牌号";
            dataGridView1.Columns[2].HeaderText = "充值时间";
            dataGridView1.Columns[3].HeaderText = "充值时长";
            dataGridView1.Columns[4].HeaderText = "到期时间";
            dataGridView1.Columns[5].HeaderText = "停车位系统编号";
            dataGridView1.Columns[6].HeaderText = "备注";

            database.dbConn.Close();
        }
    }
}
