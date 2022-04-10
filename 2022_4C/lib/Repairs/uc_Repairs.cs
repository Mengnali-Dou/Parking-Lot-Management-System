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

namespace _2022_4C.lib.Repairs
{
    public partial class uc_Repairs : UserControl
    {
        public uc_Repairs()
        {
            InitializeComponent();
        }

        private void uc_Repairs_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from TRMalfunction";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "报修单号";
            dataGridView1.Columns[1].HeaderText = "日期";
            dataGridView1.Columns[2].HeaderText = "故障类型";
            dataGridView1.Columns[3].HeaderText = "故障物品";
            dataGridView1.Columns[4].HeaderText = "故障地点";
            dataGridView1.Columns[5].HeaderText = "是否处理";
            dataGridView1.Columns[6].HeaderText = "维修员";
            dataGridView1.Columns[7].HeaderText = "备注";
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        /// <summary>
        /// 报修
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_repairSonInsert from_insert = new form_repairSonInsert();
            from_insert.ShowDialog();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtMalNum.Text;
            string oper = txtChargeOperator.Text;
            string malfunction = comMalfunction.Text;
            string date = dateTimePicker1.Text;
            string select = "";

            if (num == string.Empty && oper == string.Empty && malfunction == string.Empty)
            {
                select = "select * from TRMalfunction";
            }
            else if (num != string.Empty && oper == string.Empty && malfunction == string.Empty)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}'";
            }
            else if (num == string.Empty && oper != string.Empty && malfunction == string.Empty)
            {
                select = $"select * from TRMalfunction where ChargeOperator = '{oper}'";
            }
            else if (num == string.Empty && oper == string.Empty && malfunction != string.Empty)
            {
                select = $"select * from TRMalfunction where Malfunction = '{malfunction}'";
            }
            else if (num == string.Empty && oper == string.Empty && malfunction == string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRMalfunction where MalTime = '{date}'";
            }
            else if (num != string.Empty && oper != string.Empty && malfunction == string.Empty)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}' and ChargeOperator = '{oper}'";
            }
            else if (num != string.Empty && oper == string.Empty && malfunction != string.Empty)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}' and Malfunction = '{malfunction}'";
            }
            else if (num != string.Empty && oper == string.Empty && malfunction == string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}' and MalTime = '{date}'";
            }
            else if (num == string.Empty && oper != string.Empty && malfunction != string.Empty)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}' and ChargeOperator = '{oper}'";
            }
            else if (num == string.Empty && oper != string.Empty && malfunction == string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRMalfunction where ChargeOperator = '{oper}' and Malfunction = '{malfunction}'";
            }
            else if (num == string.Empty && oper == string.Empty && malfunction != string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRMalfunction where Malfunction = '{malfunction}' and MalTime = '{date}'";
            }
            else if (num != string.Empty && oper != string.Empty && malfunction != string.Empty)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}' and ChargeOperator = '{oper}' and Malfunction = '{malfunction}'";
            }
            else if (num == string.Empty && oper != string.Empty && malfunction != string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRMalfunction where MalTime = '{date}' and ChargeOperator = '{oper}' and Malfunction = '{malfunction}'";
            }
            else if (num != string.Empty && oper == string.Empty && malfunction != string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}' and MalTime = '{date}' and Malfunction = '{malfunction}'";
            }
            else if (num != string.Empty && oper != string.Empty && malfunction == string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}' and ChargeOperator = '{oper}' and MalTime = '{date}'";
            }
            else if (num != string.Empty && oper != string.Empty && malfunction != string.Empty && checkBox1.Checked)
            {
                select = $"select * from TRMalfunction where MalNum = '{num}' and ChargeOperator = '{oper}' and Malfunction = '{malfunction}' and MalTime = '{date}'";
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            database.dbConn.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtMalNum.Text;
            string update = null;

            if (num == string.Empty)
            {
                DialogResult dialog = MessageBox.Show("请输入报修单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtMalNum.Focus();
                }
            }
            else
            {
                string select = $"select * from TRMalfunction where MalNum = '{num}'";
                OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
                DataTable dt = new DataTable();
                myCommand.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog = MessageBox.Show("未查询到报修单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        txtMalNum.Focus();
                    }
                }
                else
                {
                    update = $"update TRMalfunction set Malfunction where MalNum = '{num}'";
                    OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                    cmd.ExecuteNonQuery();
                    DialogResult success = MessageBox.Show("完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (success == DialogResult.OK)
                    {
                        txtMalNum.Focus();
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
