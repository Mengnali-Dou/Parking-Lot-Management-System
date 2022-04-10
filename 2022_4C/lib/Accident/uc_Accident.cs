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

namespace _2022_4C.lib.Accident
{
    public partial class uc_Accident : UserControl
    {
        public uc_Accident()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtAccidentNum.Text;
            string date = dateTimePicker1.Text;
            string finsh = comboBox1.Text;
            string select = null;

            if (num == string.Empty && finsh == string.Empty)
            {
                select = $"select * from TRVehicleTraffic";
            }
            else if (num != string.Empty && finsh == string.Empty)
            {
                select = $"select * from TRVehicleTraffic where TraNum = '{num}'";
            }
            else if (num == string.Empty && finsh != string.Empty)
            {
                select = $"select * from TRVehicleTraffic where Traffic = '{finsh}'";
            }
            else if (num == string.Empty && finsh == string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRVehicleTraffic where TraDate = '{date}'";
            }
            else if (num != string.Empty && finsh != string.Empty)
            {
                select = $"select * from TRVehicleTraffic where TraNum = '{num}' and Traffic = '{finsh}'";
            }
            else if (num != string.Empty && finsh == string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRVehicleTraffic where TraNum = '{num}' and TraDate = '{date}'";
            }
            else if (num == string.Empty && finsh != string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRVehicleTraffic where Traffic = '{finsh}' and TraDate = '{date}'";
            }
            else if (num != string.Empty && finsh != string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRVehicleTraffic where TraNum = '{num}' and Traffic = '{finsh}' and TraDate = '{date}'";
            }
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            database.dbConn.Close();
        }

        private void uc_Accident_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from TRVehicleTraffic";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            inst.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "反馈单号";
            dataGridView1.Columns[1].HeaderText = "日期";
            dataGridView1.Columns[2].HeaderText = "反馈类型";
            dataGridView1.Columns[3].HeaderText = "反馈信息";
            dataGridView1.Columns[4].HeaderText = "车主姓名";
            dataGridView1.Columns[5].HeaderText = "联系方式";
            dataGridView1.Columns[6].HeaderText = "是否处理";
            dataGridView1.Columns[7].HeaderText = "备注";
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_sonInsert form = new form_sonInsert();
            form.ShowDialog();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtAccidentNum.Text;
            string select = null;
            string update = null;

            if (num == string.Empty)
            {
                DialogResult dialog = MessageBox.Show("请输入反馈单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtAccidentNum.Focus();
                }
            }
            else
            {
                select = $"select * from TRVehicleTraffic where TraNum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog = MessageBox.Show("未查询到此单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        txtAccidentNum.Focus();
                    }
                }
                else
                {
                    update = $"update TRVehicleTraffic set Traffic = '是' where TraNum = '{num}'";
                    OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                    cmd.ExecuteNonQuery();
                    OleDbDataAdapter upd = new OleDbDataAdapter("select * from TRVehicleTraffic", database.dbConn);
                    DataSet ds_2 = new DataSet();
                    upd.Fill(ds_2);
                    dataGridView1.DataSource = ds_2.Tables[0];
                }
            }

            database.dbConn.Close();
        }
    }
}
