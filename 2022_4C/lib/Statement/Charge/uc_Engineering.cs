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
    public partial class uc_Engineering : UserControl
    {
        public uc_Engineering()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string con_num = txtConNum.Text;
            string item_num = txtItemNum.Text;
            string park = txtPark.Text;
            string select = null;

            if (con_num == string.Empty && item_num == string.Empty && park == string.Empty)
            {
                select = "select * from PUEngineeringConstruction";
            }
            else if (con_num != string.Empty)
            {
                select = $"select * from PUEngineeringConstruction where ConNum = '{con_num}'";
            }
            else
            {
                if (item_num != string.Empty && park == string.Empty)
                {
                    select = $"select * from PUEngineeringConstruction where ItemNum = '{item_num}'";
                }
                else if (item_num == string.Empty && park != string.Empty)
                {
                    select = $"select * from PUEngineeringConstruction where ParkNum = '{park}'";
                }
                else if (item_num != string.Empty && park != string.Empty)
                {
                    select = $"select * from PUEngineeringConstruction where ItemNum = '{item_num}' and ParkNum = '{park}'";
                }
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "施工单号";
            dataGridView1.Columns[1].HeaderText = "项目编号";
            dataGridView1.Columns[2].HeaderText = "项目名";
            dataGridView1.Columns[3].HeaderText = "开始时间";
            dataGridView1.Columns[4].HeaderText = "结束时间";
            dataGridView1.Columns[5].HeaderText = "停车场";
            dataGridView1.Columns[6].HeaderText = "花费金额";
            dataGridView1.Columns[7].HeaderText = "操作员";
            dataGridView1.Columns[8].HeaderText = "备注";
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_Eng form = new form_Eng();
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtConNum.Text;
            string delete = null;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("请输入施工单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtConNum.Focus();
                }
            }
            else
            {
                string select = $"select * from PUEngineeringConstruction where ConNum = '{num}'";
                OleDbDataAdapter sel = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                sel.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult dialog2 = MessageBox.Show("未查询到此施工单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog2 == DialogResult.OK)
                    {
                        txtConNum.Focus();
                    }
                }
                else
                {
                    delete = $"delete PUEngineeringConstruction where ConNum = '{num}'";
                    OleDbCommand myCommand = new OleDbCommand(delete, database.dbConn);
                    myCommand.ExecuteNonQuery();
                    DialogResult dialog3 = MessageBox.Show("已删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog3 == DialogResult.OK)
                    {
                        txtConNum.Focus();
                    }
                    OleDbDataAdapter inst = new OleDbDataAdapter("select * from PUEngineeringConstruction", database.dbConn);
                    DataSet ds = new DataSet();
                    inst.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }

            database.dbConn.Close();
        }

        private void btnConSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtNum.Text;
            string type = txtType.Text;
            string select = null;

            if (num == string.Empty && type == string.Empty)
            {
                select = "select * from PUConstructionItem";
            }
            else if (num != string.Empty)
            {
                select = $"select * from PUConstructionItem where ItemNum = '{num}'";
            }
            else if (num == string.Empty && type != string.Empty)
            {
                select = $"select * from PUConstructionItem where ItemType = '{type}'";
            }
            else if (num != string.Empty && type != string.Empty)
            {
                select = $"select * from PUConstructionItem where ItemNum = '{num}'";
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "项目编号";
            dataGridView1.Columns[1].HeaderText = "项目类型";
            dataGridView1.Columns[2].HeaderText = "备注";
            for (int i = 0; i < 2; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnConInsert_Click(object sender, EventArgs e)
        {
            form_ConInsert form = new form_ConInsert();
            form.ShowDialog();
        }
    }
}
