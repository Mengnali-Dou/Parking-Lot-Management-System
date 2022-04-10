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
    public partial class uc_sonIdleRentLog : UserControl
    {
        public uc_sonIdleRentLog()
        {
            InitializeComponent();
        }

        private void uc_sonIdleRentLog_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from LOIdleRent";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "日志编号";
            dataGridView1.Columns[1].HeaderText = "车位系统编号";
            dataGridView1.Columns[2].HeaderText = "停放车辆";
            dataGridView1.Columns[3].HeaderText = "停放时间";
            dataGridView1.Columns[4].HeaderText = "离开时间";
            dataGridView1.Columns[5].HeaderText = "备注";
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string vehicle = txtVehicle.Text;
            string parking = txtParking.Text;
            string select = null;

            if (num == string.Empty && vehicle == string.Empty && parking == string.Empty)
            {
                select = "select * from LOIdleRent";
            }
            else if (num != string.Empty && vehicle == string.Empty && parking == string.Empty)
            {
                select = $"select * from LOIdleRent where LOIRNum = '{num}'";
            }
            else if (num == string.Empty && vehicle != string.Empty && parking == string.Empty)
            {
                select = $"select * from LOIdleRent where ParkingVehicle = '{vehicle}'";
            }
            else if (num == string.Empty && vehicle == string.Empty && parking != string.Empty)
            {
                select = $"select * from LOIdleRent where PSSystemNum = '{parking}'";
            }
            else if (num != string.Empty && vehicle != string.Empty && parking == string.Empty)
            {
                select = $"select * from LOIdleRent where LOIRNum = '{num}' and ParkingVehicle = '{vehicle}'";
            }
            else if (num != string.Empty && vehicle == string.Empty && parking != string.Empty)
            {
                select = $"select * from LOIdleRent where LOIRNum = '{num}' and PSSystemNum = '{parking}'";
            }
            else if (num == string.Empty && vehicle != string.Empty && parking != string.Empty)
            {
                select = $"select * from LOIdleRent where ParkingVehicle = '{vehicle}' and PSSystemNum = '{parking}'";
            }
            else if (num != string.Empty && vehicle != string.Empty && parking != string.Empty)
            {
                select = $"select * from LOIdleRent where LOIRNum = '{num}' and ParkingVehicle = '{vehicle}' and PSSystemNum = '{parking}'";
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            database.dbConn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string delete = null;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入日志编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtLONum.Focus();
                }
            }
            else
            {
                string select = $"select * from LOIdleRent where LOIRNum = '{num}'";
                OleDbDataAdapter myCommand = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                myCommand.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog2 = MessageBox.Show("未查询到此日志", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtLONum.Focus();
                    }
                }
                else
                {
                    DialogResult dialog3 = MessageBox.Show("确定删除？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialog3 == DialogResult.OK)
                    {
                        delete = $"delete LOIDleRent where LOIRNum = '{num}'";
                        OleDbCommand cmd = new OleDbCommand(delete, database.dbConn);
                        cmd.ExecuteNonQuery();
                        DialogResult dialog4 = MessageBox.Show("删除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog4 == DialogResult.OK)
                        {
                            txtLONum.Focus();
                        }
                    }
                    else
                    {
                        txtLONum.Focus();
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
