using _2022_4C.data;
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

namespace _2022_4C.lib.Park.Insert
{
    public partial class uc_DisArea : UserControl
    {
        public uc_DisArea()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string park = txtPark.Text;
            string parkingspot = txtParkingSpot.Text;
            string select = null;

            if (park == string.Empty && parkingspot == string.Empty)
            {
                select = "select * from PAParkingArea";
            }
            else if (park != string.Empty && parkingspot == string.Empty)
            {
                select = $"select * from PAParkingArea where PSystemNum = '{park}'";
            }
            else if (parkingspot != string.Empty)
            {
                select = $"select * from PAParkingArea where PASystemNum = '{parkingspot}'";
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "停车区系统编号";
            dataGridView1.Columns[1].HeaderText = "停车区编号";
            dataGridView1.Columns[2].HeaderText = "停车场系统编号";
            dataGridView1.Columns[3].HeaderText = "备注";
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_dis_sonInsertArea form = new form_dis_sonInsertArea();
            form.ShowDialog();
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            form_disSonUpdate form = new form_disSonUpdate(this);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtPark.Text;
            string delete = null;

            if (num == string.Empty)
            {
                DialogResult dialog1 = MessageBox.Show("未查询到此停车区", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.OK)
                {
                    txtPark.Focus();
                }
            }
            else
            {
                DialogResult dialog2 = MessageBox.Show("确定要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog2 == DialogResult.OK)
                {
                    delete = $"delete from PAParkingArea where PASystemNum = '{num}'";
                    OleDbCommand myCommand1 = new OleDbCommand(delete, database.dbConn);
                    myCommand1.ExecuteNonQuery();

                    string LOPANum = GenerateLOParkingAreaNum.generatle();
                    string date = DateTime.Now.ToShortDateString().ToString();
                    string even = "删除停车区";
                    string abnormal = "否";
                    string insert = $"insert into LOParkingArea (LOPANum,LOPADate,LOPAEvent,LOPAAbnormal,LOPAComment) values ('{LOPANum}','{date}','{even}','{abnormal}','')";
                    OleDbCommand myCommand2 = new OleDbCommand(insert, database.dbConn);
                    myCommand2.ExecuteNonQuery();

                    DialogResult dialog3 = MessageBox.Show("已删除", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog3 == DialogResult.OK)
                    {
                        txtPark.Focus();
                    }
                }
                else
                {
                    txtPark.Focus();
                }
            }

            database.dbConn.Close();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            form_InsertArea form = new form_InsertArea();
            form.ShowDialog();
        }
    }
}
