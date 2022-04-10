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

namespace _2022_4C.lib.EmployeeImage
{
    public partial class uc_sonExpend : UserControl
    {
        public uc_sonExpend()
        {
            InitializeComponent();
        }

        private void uc_sonExpend_Load(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = @"select * from BAExpenseAccount";
            OleDbDataAdapter cmd = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "报销单号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "发票单号";
            dataGridView1.Columns[3].HeaderText = "报销金额（元）";
            dataGridView1.Columns[4].HeaderText = "报销项目";
            dataGridView1.Columns[5].HeaderText = "备注";

            database.dbConn.Close();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string id = txtEmployeeID.Text;
            string ea_num = txtEANum.Text;
            string invoice_num = txtInvoiceNum.Text;

            string select = null;

            if (id == string.Empty && ea_num == string.Empty && invoice_num == string.Empty)    // 未输入查询条件
            {
                select = @"select * from BAExpenseAccount";
            }
            else if (id != string.Empty && ea_num == string.Empty && invoice_num == string.Empty)    // 按id查询
            {
                select = $@"select * from BAExpenseAccount where EmployeeID = '{id}'";
            }
            else if (id == string.Empty && ea_num != string.Empty && invoice_num == string.Empty)    // 按报销单号查询
            {
                select = $@"select * from BAExpenseAccount where EANum = '{ea_num}'";
            }
            else if (id == string.Empty && ea_num == string.Empty && invoice_num != string.Empty)    // 按项目编号查询
            {
                select = $@"select * from BAExpenseAccount where InvoiceNum = '{invoice_num}'";
            }
            else if (id != string.Empty && ea_num != string.Empty && invoice_num == string.Empty)
            {
                select = $@"select * from BAExpenseAccount where InvoiceNum = '{invoice_num}'";
            }
            else if (id != string.Empty && ea_num == string.Empty && invoice_num != string.Empty)
            {
                select = $@"select * from BAExpenseAccount where InvoiceNum = '{invoice_num}'";
            }
            else if (id == string.Empty && ea_num != string.Empty && invoice_num != string.Empty)
            {
                select = $@"select * from BAExpenseAccount where InvoiceNum = '{invoice_num}'";
            }
            else
            {
                select = $@"select * from BAExpenseAccount where InvoiceNum = '{invoice_num}'";
            }
            OleDbDataAdapter cmd = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "报销单号";
            dataGridView1.Columns[1].HeaderText = "员工账号";
            dataGridView1.Columns[2].HeaderText = "发票单号";
            dataGridView1.Columns[3].HeaderText = "报销金额（元）";
            dataGridView1.Columns[4].HeaderText = "报销项目";
            dataGridView1.Columns[5].HeaderText = "备注";
            database.dbConn.Close();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_BAEAInsert form = new form_BAEAInsert();
            form.ShowDialog();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butUpdate_Click(object sender, EventArgs e)
        {
            form_BAEAUpdate form_update = new form_BAEAUpdate();
            form_update.ShowDialog();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtEANum.Text;
            if (num == string.Empty)
            {
                DialogResult result1 = MessageBox.Show("请输入报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtEANum.Focus();
                }
            }
            else
            {
                string select = $"select * from BAExpenseAccount where EANum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult result2 = MessageBox.Show("无此报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        txtEANum.Focus();
                    }
                }
                else
                {
                    DialogResult result3 = MessageBox.Show("确定删除？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result3 == DialogResult.OK)
                    {
                        string delete = $"delete from BAExpenseAccount where EANum = '{num}'";
                        OleDbCommand cmd_delete = new OleDbCommand(delete, database.dbConn);
                        cmd_delete.ExecuteNonQuery();
                        OleDbDataAdapter inst_delete = new OleDbDataAdapter("select * from BAExpenseAccount", database.dbConn);
                        DataSet ds_delete = new DataSet();
                        inst_delete.Fill(ds_delete);
                        dataGridView1.DataSource = ds_delete.Tables[0];
                    }
                    else
                    {
                        txtEANum.Focus();
                    }
                }
            }
            database.dbConn.Close();
        }

        /// <summary>
        /// 报销批准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQualified_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtENum.Text;
            if (num == string.Empty)
            {
                DialogResult result2 = MessageBox.Show("请输入报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    txtENum.Focus();
                }
            }
            else
            {
                string select = $"select * from BAExpenseAccount where EANum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult result2 = MessageBox.Show("无此报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        txtEANum.Focus();
                    }
                }
                else
                {
                    string update = $"update BAExpenseAccount set EAComment = '批准' where EANum = '{num}'";
                    OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                    cmd.ExecuteNonQuery();
                    OleDbDataAdapter inst_delete = new OleDbDataAdapter("select * from BAExpenseAccount where EANum = '{num}'", database.dbConn);
                    DataSet ds_delete = new DataSet();
                    inst_delete.Fill(ds_delete);
                    dataGridView1.DataSource = ds_delete.Tables[0];
                }
            }
            database.dbConn.Close();
        }

        /// <summary>
        /// 报销不批准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string num = txtENum.Text;
            if (num == string.Empty)
            {
                DialogResult result2 = MessageBox.Show("请输入报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    txtENum.Focus();
                }
            }
            else
            {
                string select = $"select * from BAExpenseAccount where EANum = '{num}'";
                OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
                DataTable dt = new DataTable();
                inst.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    DialogResult result2 = MessageBox.Show("无此报销单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        txtEANum.Focus();
                    }
                }
                else
                {
                    string update = $"updata BAExpenseAccount set EAComment = '不批准' where EANum = '{num}'";
                    OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
                    cmd.ExecuteNonQuery();
                    OleDbDataAdapter inst_delete = new OleDbDataAdapter("select * from BAExpenseAccount where EANum = '{num}'", database.dbConn);
                    DataSet ds_delete = new DataSet();
                    inst_delete.Fill(ds_delete);
                    dataGridView1.DataSource = ds_delete.Tables[0];
                }
            }
            database.dbConn.Close();
        }
    }
}
