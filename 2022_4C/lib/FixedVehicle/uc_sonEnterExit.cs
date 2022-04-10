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

namespace _2022_4C.lib.FixedVehicle
{
    public partial class uc_sonEnterExit : UserControl
    {
        public uc_sonEnterExit()
        {
            InitializeComponent();
        }

        private void uc_sonEnterExit_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from LOEnterExit";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "日志编号";
            dataGridView1.Columns[1].HeaderText = "订单号";
            dataGridView1.Columns[2].HeaderText = "车位系统编号";
            dataGridView1.Columns[3].HeaderText = "车辆类型";
            dataGridView1.Columns[4].HeaderText = "车牌号/通行证号";
            dataGridView1.Columns[5].HeaderText = "进场时间";
            dataGridView1.Columns[6].HeaderText = "出场时间";
            dataGridView1.Columns[7].HeaderText = "停车时长";
            dataGridView1.Columns[8].HeaderText = "备注";
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string order = txtOrderNum.Text;
            string park = txtParkingSpot.Text;
            string type = txtVehicleType.Text;
            string license = txtLicense.Text;
            string select = null;

            if (num == string.Empty && order == string.Empty && park == string.Empty && type == string.Empty && license == string.Empty)
            {
                select = "select * from LOEnterExit";
            }
            else if (num != string.Empty && order == string.Empty)
            {
                select = $"select * from LOEnterExit where LOEENum = '{num}'";
            }
            else if (num == string.Empty && order != string.Empty)
            {
                select = $"select * from LOEnterExit where OrderFormNum = '{order}'";
            }
            else if (num != string.Empty && order != string.Empty)
            {
                select = $"select * from LOEnterExit where LOEENum = '{num}'";
            }
            else if (num == string.Empty && order == string.Empty && park != string.Empty && type == string.Empty && license == string.Empty)
            {
                select = $"select * from LOEnterExit where PSSystemNum = '{park}'";
            }
            else if (num == string.Empty && order == string.Empty && park == string.Empty && type != string.Empty && license == string.Empty)
            {
                select = $"select * from LOEnterExit where VehicleType = '{type}'";
            }
            else if (num == string.Empty && order == string.Empty && park == string.Empty && type == string.Empty && license != string.Empty)
            {
                select = $"select * from LOEnterExit where VehicleNum = '{license}'";
            }
            else if (num == string.Empty && order == string.Empty && park != string.Empty && type != string.Empty && license == string.Empty)
            {
                select = $"select * from LOEnterExit where LOEENum = '{num}' and VehicleType = '{type}'";
            }
            else if (num == string.Empty && order == string.Empty && park != string.Empty && type == string.Empty && license != string.Empty)
            {
                select = $"select * from LOEnterExit where LOEENum = '{num}' and VehicleNum = '{license}'";
            }
            else if (num == string.Empty && order == string.Empty && park == string.Empty && type != string.Empty && license != string.Empty)
            {
                select = $"select * from LOEnterExit where VehicleType = '{type}' and VehicleNum = '{license}'";
            }
            else if (num == string.Empty && order == string.Empty && park != string.Empty && type != string.Empty && license != string.Empty)
            {
                select = $"select * from LOEnterExit where LOEENum = '{num}' and VehicleType = '{type}' and VehicleNum = '{license}'";
            }
            OleDbDataAdapter cmd = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            database.dbConn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string order = txtOrderNum.Text;
            string delete = null;
            string select = null;

            if (num == string.Empty && order == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入日志编号或订单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtLONum.Focus();
                }
            }
            else
            {
                if (num != string.Empty && order == string.Empty)
                {
                    select = $"select * from LOEnterExit where LOEENum = '{num}'";
                    OleDbDataAdapter inst_1 = new OleDbDataAdapter(select, database.dbConn);
                    DataTable dt_1 = new DataTable();
                    inst_1.Fill(dt_1);
                    if (dt_1.Rows.Count == 0)
                    {
                        DialogResult dialog1 = MessageBox.Show("未查询到日志编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog1 == DialogResult.OK)
                        {
                            txtLONum.Focus();
                        }
                    }
                    else
                    {
                        delete = $"delete from LOEnterExit where LOEENum = '{num}'";
                        OleDbDataAdapter inst = new OleDbDataAdapter("select * from BAAdmin", database.dbConn);
                        DataSet ds = new DataSet();
                        inst.Fill(ds);
                    }
                }
                else
                {
                    select = $"select * from LOEnterExit where OrderFormNum = '{order}'";
                    OleDbDataAdapter inst_2 = new OleDbDataAdapter(select, database.dbConn);
                    DataTable dt_2 = new DataTable();
                    inst_2.Fill(dt_2);
                    if (dt_2.Rows.Count == 0)
                    {
                        DialogResult dialog1 = MessageBox.Show("未查询到日志编号/订单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog1 == DialogResult.OK)
                        {
                            txtLicense.Focus();
                        }
                    }
                    else
                    {
                        delete = $"delete from LOEnterExit where OrderFormNum = '{order}'";
                        OleDbDataAdapter inst = new OleDbDataAdapter("select * from BAAdmin", database.dbConn);
                        DataSet ds = new DataSet();
                        inst.Fill(ds);
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
