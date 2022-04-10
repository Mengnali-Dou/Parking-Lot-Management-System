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
    public partial class uc_sonParkLog : UserControl
    {
        public uc_sonParkLog()
        {
            InitializeComponent();
        }

        private void uc_sonParkLog_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from LOPark";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "日志编号";
            dataGridView1.Columns[1].HeaderText = "日期";
            dataGridView1.Columns[2].HeaderText = "内容";
            dataGridView1.Columns[3].HeaderText = "是否异常";
            dataGridView1.Columns[4].HeaderText = "备注";
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtLONum.Text;
            string abnormal = comboBox1.Text;
            string date = dateTimePicker1.Text;
            string select = null;

            if (num == string.Empty && abnormal == string.Empty)
            {
                select = "select * from LOPark";
            }
            else if (num != string.Empty && abnormal == string.Empty)
            {
                select = $"select * from LOPark where LOPNum = '{num}'";
            }
            else if (num == string.Empty && abnormal != string.Empty)
            {
                select = $"select * from LOPark where LOPAbnormal = '{abnormal}'";
            }
            else if (num == string.Empty && abnormal == string.Empty && checkBox1.Checked)
            {
                select = $"select * from LOPark where LOPDate = '{date}'";
            }
            else if (num != string.Empty && abnormal != string.Empty)
            {
                select = $"select * from LOPark where LOPNum = '{num}' and LOPAbnormal = '{abnormal}'";
            }
            else if (num != string.Empty && abnormal == string.Empty && checkBox1.Checked)
            {
                select = $"select * from LOPark where LOPNum = '{num}' and LOPDate = '{date}'";
            }
            else if (num == string.Empty && abnormal != string.Empty && checkBox1.Checked)
            {
                select = $"select * from LOPark where LOPAbnormal = '{abnormal}' and LOPDate = '{date}'";
            }
            else if (num != string.Empty && abnormal != string.Empty && checkBox1.Checked)
            {
                select = $"select * from LOPark where LOPNum = '{num}' and LOPAbnormal = '{abnormal}' and LOPDate = '{date}'";
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
                string select = $"select LOPNum from LOPark where LOPNum = '{num}'";
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
                        delete = $"delete from LOPark where LOPNum = '{num}'";
                        OleDbCommand cmd = new OleDbCommand(delete, database.dbConn);
                        cmd.ExecuteNonQuery();
                        DialogResult dialog5 = MessageBox.Show("删除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog5 == DialogResult.OK)
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

        private void btnAbnormal_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtNum.Text;
            string update = null;
            if (num == string.Empty)
            {
                DialogResult dialog4 = MessageBox.Show("请输入日志编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog4 == DialogResult.OK)
                {
                    txtNum.Focus();
                }
            }
            else
            {
                string select = $"select LOPNum from LOPark where LOPNum = '{num}'";
                OleDbDataAdapter myCommand_1 = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt_1 = new DataTable();
                myCommand_1.Fill(dt_1);
                if (dt_1.Rows.Count == 0)
                {
                    DialogResult dialog5 = MessageBox.Show("未查询到此日志", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog5 == DialogResult.OK)
                    {
                        txtNum.Focus();
                    }
                }
                else
                {
                    update = $"update LOPark set LOPAbnormal = '无异常' where LOPNum = '{num}'";
                    OleDbCommand myCommand_2 = new OleDbCommand(update, database.dbConn);
                    myCommand_2.ExecuteNonQuery();
                    DialogResult dialog6 = MessageBox.Show("未查询到此日志", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog6 == DialogResult.OK)
                    {
                        OleDbDataAdapter myCommand = new OleDbDataAdapter(select, database.dbConn);
                        DataSet ds = new DataSet();
                        myCommand.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }

            database.dbConn.Close();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtNum.Text;
            string update = null;
            if (num == string.Empty)
            {
                DialogResult dialog4 = MessageBox.Show("请输入日志编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog4 == DialogResult.OK)
                {
                    txtNum.Focus();
                }
            }
            else
            {
                string select = $"select LOPANum from LOPark where LOPNum = '{num}'";
                OleDbDataAdapter myCommand_1 = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt_1 = new DataTable();
                myCommand_1.Fill(dt_1);
                if (dt_1.Rows.Count == 0)
                {
                    DialogResult dialog5 = MessageBox.Show("未查询到此日志", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog5 == DialogResult.OK)
                    {
                        txtNum.Focus();
                    }
                }
                else
                {
                    update = $"update LOParking set LOPAbnormal = '无异常' where LOPNum = '{num}'";
                    OleDbCommand myCommand_2 = new OleDbCommand(update, database.dbConn);
                    myCommand_2.ExecuteNonQuery();
                    DialogResult dialog6 = MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog6 == DialogResult.OK)
                    {
                        OleDbDataAdapter myCommand = new OleDbDataAdapter(select, database.dbConn);
                        DataSet ds = new DataSet();
                        myCommand.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
