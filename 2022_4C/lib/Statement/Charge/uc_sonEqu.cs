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

namespace _2022_4C.lib.Statement.Charge
{
    public partial class uc_sonEqu : UserControl
    {
        public uc_sonEqu()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string pur_num = txtPurNum.Text;
            string equ_num = txtEquNum.Text;
            string park = txtPark.Text;
            string date = dateTimePicker1.Text;
            string select = null;

            if (pur_num == string.Empty && equ_num == string.Empty && park == string.Empty)
            {
                select = "select * from PUEquipmentPurchasing";
            }
            else if (pur_num != string.Empty)
            {
                select = $"select * from PUEquipmentPurchasing where PurNum = '{pur_num}'";
            }
            else
            {
                if (equ_num != string.Empty && park == string.Empty)
                {
                    select = $"select * from PUEquipmentPurchasing where EquNum = '{equ_num}'";
                }
                else if (equ_num == string.Empty && park != string.Empty)
                {
                    select = $"select * from PUEquipmentPurchasing where ParkNum = '{park}'";
                }
                else if (equ_num == string.Empty && park == string.Empty && checkBox1.Checked)
                {
                    select = $"select * from PUEquipmentPurchasing where PurDate = '{date}'";
                }
                else if (equ_num != string.Empty && park != string.Empty)
                {
                    select = $"select * from PUEquipmentPurchasing where PurNum = '{pur_num}' and ParkNum = '{park}'";
                }
                else if (equ_num != string.Empty && park == string.Empty && checkBox1.Checked)
                {
                    select = $"select * from PUEquipmentPurchasing where PurNum = '{pur_num}' and PurDate = '{date}'";
                }
                else if (equ_num == string.Empty && park != string.Empty && checkBox1.Checked)
                {
                    select = $"select * from PUEquipmentPurchasing where ParkNum = '{park}' and PurDate = '{date}'";
                }
                else if (equ_num != string.Empty && park != string.Empty && checkBox1.Checked)
                {
                    select = $"select * from PUEquipmentPurchasing where PurNum = '{pur_num}' and ParkNum = '{park}' and PurDate = '{date}'";
                }
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "采购编号";
            dataGridView1.Columns[1].HeaderText = "时间";
            dataGridView1.Columns[2].HeaderText = "设备编号";
            dataGridView1.Columns[3].HeaderText = "数量";
            dataGridView1.Columns[4].HeaderText = "金额";
            dataGridView1.Columns[5].HeaderText = "停车场";
            dataGridView1.Columns[6].HeaderText = "操作员";
            dataGridView1.Columns[7].HeaderText = "备注";
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_Equ form = new form_Equ();
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtPurNum.Text;
            string delete = null;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入采购编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPurNum.Focus();
                }
            }
            else
            {
                string select = $"select * from PUEquipmentPurchasing where PurNum = '{num}'";
                OleDbDataAdapter sel = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                sel.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog2 = MessageBox.Show("未查询到此采购编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtPurNum.Focus();
                    }
                }
                else
                {
                    delete = $"delete PUEquipmentPurchasing wherr PurNum = '{num}'";
                    OleDbCommand myCommand = new OleDbCommand(delete, database.dbConn);
                    myCommand.ExecuteNonQuery();
                    DialogResult dialog3 = MessageBox.Show("已删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog3 == DialogResult.OK)
                    {
                        txtPurNum.Focus();
                    }
                    OleDbDataAdapter inst = new OleDbDataAdapter("select * from PUEquipmentPurchasing", database.dbConn);
                    DataSet ds = new DataSet();
                    inst.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }

            database.dbConn.Close();
        }

        private void btnEquSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtNum.Text;
            string name = txtName.Text;
            string select = null;

            if (num == string.Empty && name == string.Empty)
            {
                select = "select * from PUEquipment";
            }
            else if (num != string.Empty)
            {
                select = $"select * from PUEquipment where EqNum = '{num}'";
            }
            else if (num == string.Empty && name != string.Empty)
            {
                select = $"select * from PUEquipment where EqName = '{name}'";
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "设备编号";
            dataGridView1.Columns[1].HeaderText = "设备名";
            dataGridView1.Columns[2].HeaderText = "设备单价";
            dataGridView1.Columns[3].HeaderText = "备注";
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnEquInsert_Click(object sender, EventArgs e)
        {
            form_EquInsert form = new form_EquInsert();
            form.ShowDialog();
        }
    }
}
