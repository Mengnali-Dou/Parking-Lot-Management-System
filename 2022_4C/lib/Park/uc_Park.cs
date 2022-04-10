using _2022_4C.data;
using _2022_4C.lib.FixedVehicle;
using _2022_4C.lib.Park.Insert;
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

namespace _2022_4C.lib.Park
{
    public partial class uc_Park : UserControl
    {
        public uc_DisArea uc_DI;
        public uc_sonParkSpotLog uc_PS;
        public uc_sonParkLog uc_PA;

        public uc_Park()
        {
            InitializeComponent();
            uc_DI = new uc_DisArea();
            uc_PS = new uc_sonParkSpotLog();
            uc_PA = new uc_sonParkLog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(dataGridView1);

            database.dbConn.Open();

            string park = txtPark.Text;
            string parkingSpot = txtParkingSpot.Text;

            if (park != string.Empty && parkingSpot != string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("只能输入一个查询条件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPark.Focus();
                }
            }
            else
            {
                if (park == string.Empty && parkingSpot == string.Empty)
                {
                    string select_1 = "select * from PAPark";
                    OleDbDataAdapter cmd_1 = new OleDbDataAdapter(@select_1, database.dbConn);
                    DataSet ds_1 = new DataSet();
                    cmd_1.Fill(ds_1);
                    dataGridView1.DataSource = ds_1.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "停车场系统编号";
                    dataGridView1.Columns[1].HeaderText = "名称";
                    dataGridView1.Columns[2].HeaderText = "备注";
                    for (int i = 0; i < 2; i++)
                    {
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
                else if (park != string.Empty && parkingSpot == string.Empty)
                {
                    string select_2 = $"select * from PAParkingArea where PSystemNum = '{park}'";
                    OleDbDataAdapter cmd_2 = new OleDbDataAdapter(@select_2, database.dbConn);
                    DataSet ds_2 = new DataSet();
                    cmd_2.Fill(ds_2);
                    dataGridView1.DataSource = ds_2.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "停车区系统编号";
                    dataGridView1.Columns[1].HeaderText = "停车区编号";
                    dataGridView1.Columns[2].HeaderText = "停车场系统编号";
                    dataGridView1.Columns[3].HeaderText = "备注";
                    for (int i = 0; i < 3; i++)
                    {
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
                else if (park == string.Empty && parkingSpot != string.Empty)
                {
                    string select_3 = $"select * from PAParkingSpot where PSSystemNum = '{parkingSpot}'";
                    OleDbDataAdapter cmd_3 = new OleDbDataAdapter(@select_3, database.dbConn);
                    DataSet ds_3 = new DataSet();
                    cmd_3.Fill(ds_3);
                    dataGridView1.DataSource = ds_3.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "停车位系统编号";
                    dataGridView1.Columns[1].HeaderText = "停车位编号";
                    dataGridView1.Columns[1].HeaderText = "停车区系统编号";
                    dataGridView1.Columns[1].HeaderText = "车位类型";
                    dataGridView1.Columns[2].HeaderText = "备注";
                    for (int i = 0; i < 2; i++)
                    {
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }

            database.dbConn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form_Insert form = new form_Insert();
            form.ShowDialog();
        }

        private void btnDisArea_Click(object sender, EventArgs e)
        {
            uc_DI.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_DI);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtPark.Text;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入停车场系统编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPark.Focus();
                }
            }
            else
            {
                string select1 = $"select * from PAPark where PSystemNum = '{num}'";
                OleDbDataAdapter inst1 = new OleDbDataAdapter(select1, database.dbConn);
                DataTable dt1 = new DataTable();
                inst1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    DialogResult dialog2 = MessageBox.Show("未查询到此停车场编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtPark.Focus();
                    }
                }
                else
                {
                    DialogResult dialog3 = MessageBox.Show("确定要删除？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialog3 == DialogResult.OK)
                    {
                        string delete_park = $"delete PAPark where PSystemNum = '{num}'";
                        OleDbCommand cmd1 = new OleDbCommand(delete_park, database.dbConn); 
                        cmd1.ExecuteNonQuery();

                        string LOPNum = GenerateLOParkNum.generate();
                        string date = DateTime.Now.ToShortDateString().ToString();
                        string even_park = $"删除停车场'{num}'";
                        string insert_park = $"insert into LOPark (LOPNum,LOPDate,LOPEvent,LOPAbnormal,LOPComment) values ('{LOPNum}','{date}','{even_park}','否','')";
                        OleDbCommand cmd1_1 = new OleDbCommand(delete_park, database.dbConn);
                        cmd1_1.ExecuteNonQuery();

                        string delete_area = $"delete PAParkingArea where PSystemNum = '{num}'";
                        OleDbCommand cmd2 = new OleDbCommand(delete_area, database.dbConn);
                        cmd2.ExecuteNonQuery();

                        string LOPANum = GenerateLOParkingAreaNum.generatle();
                        string even_area = $"删除停车场'{num}'";
                        string insert_into = $"insert into LOParkingArea (LOPANum,LOPADate,LOPAEvent,LOPAAbnormal,LOPAComment) values ('{LOPANum}','{date}','{even_area}','否','')";
                        OleDbCommand cmd2_2 = new OleDbCommand(delete_park, database.dbConn);
                        cmd2_2.ExecuteNonQuery();

                        DialogResult dialog4 = MessageBox.Show("完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog4 == DialogResult.OK)
                        {
                            txtPark.Focus();
                        }
                    }
                    else
                    {
                        txtPark.Focus();
                    }
                }
            }

            database.dbConn.Close();
        }

        /// <summary>
        /// 停车区日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParkingArea_Click(object sender, EventArgs e)
        {
            uc_PS.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_PS);
        }

        /// <summary>
        /// 停车场日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPark_Click(object sender, EventArgs e)
        {
            uc_PA.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_PA);
        }
    }
}
