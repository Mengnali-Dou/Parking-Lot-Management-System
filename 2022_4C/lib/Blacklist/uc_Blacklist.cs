using _2022_4C.DB;
using _2022_4C.data;
using _2022_4C.DB.IN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace _2022_4C.lib.Blacklist
{
    public partial class uc_Blacklist : UserControl
    {
        public uc_Blacklist()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 违规车辆按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {   
            database.dbConn.Open();
            string sql = "select * from INViolationVehicle";
            OleDbDataAdapter cmd = new OleDbDataAdapter(sql,database.dbConn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "车牌号";
            dataGridView1.Columns[1].HeaderText = "违规原因";
            dataGridView1.Columns[2].HeaderText = "违规次数";
            dataGridView1.Columns[3].HeaderText = "备注";
            database.dbConn.Close();
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_Insert form = new form_Insert();
            form.ShowDialog();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string licensePlate = txtLicensePlateNum.Text;
            string ownerID = txtOwnerID.Text;
            string select = null;

            if (licensePlate == string.Empty && ownerID == string.Empty)
            {
                DialogResult result1 = MessageBox.Show("查询条件不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtLicensePlateNum.Focus();
                }
            }
            else if (licensePlate != string.Empty && ownerID != string.Empty)
            {
                DialogResult result1 = MessageBox.Show("只能输入一个查询条件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtLicensePlateNum.Focus();
                }
            }
            else
            {
                if (licensePlate == string.Empty)    // 输入了车主ID
                {
                    select = $"select * from INOwnerBlacklist where OwnerID = '{ownerID}'";
                    OleDbDataAdapter cmd_owner = new OleDbDataAdapter(select, database.dbConn);
                    DataSet ds_owner = new DataSet();
                    cmd_owner.Fill(ds_owner);
                    dataGridView1.DataSource = ds_owner.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "车主ID";
                    dataGridView1.Columns[1].HeaderText = "车主姓名";
                    dataGridView1.Columns[2].HeaderText = "标记原因";
                    dataGridView1.Columns[3].HeaderText = "操作员";
                    dataGridView1.Columns[4].HeaderText = "备注";
                }
                else    // 输入了车牌号
                {
                    select = $"select * from INVehicleBlacklist where VehicleNum = '{licensePlate}'";
                    OleDbDataAdapter cmd_vehicle = new OleDbDataAdapter(select, database.dbConn);
                    DataSet ds_vehicle = new DataSet();
                    cmd_vehicle.Fill(ds_vehicle);
                    dataGridView1.Columns[0].HeaderText = "车主ID";
                    dataGridView1.Columns[1].HeaderText = "车主姓名";
                    dataGridView1.Columns[2].HeaderText = "标记原因";
                    dataGridView1.Columns[3].HeaderText = "标记时间";
                    dataGridView1.Columns[4].HeaderText = "操作员";
                    dataGridView1.Columns[5].HeaderText = "备注";
                }
            }
            database.dbConn.Close();
        }

        /// <summary>
        /// 车辆黑名单查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBVehicle_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from INVehicleBlacklist";
            OleDbDataAdapter cmd_vehicle = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds_vehicle = new DataSet();
            cmd_vehicle.Fill(ds_vehicle);
            dataGridView1.DataSource = ds_vehicle.Tables[0];
            dataGridView1.Columns[0].HeaderText = "车牌号";
            dataGridView1.Columns[1].HeaderText = "标记原因";
            dataGridView1.Columns[2].HeaderText = "标记时间";
            dataGridView1.Columns[3].HeaderText = "操作员";
            dataGridView1.Columns[4].HeaderText = "备注";

            database.dbConn.Close();
        }

        /// <summary>
        /// 车主黑名单查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBOwner_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from INOwnerBlacklist";
            OleDbDataAdapter cmd_owner = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds_owner = new DataSet();
            cmd_owner.Fill(ds_owner);
            dataGridView1.DataSource = ds_owner.Tables[0];
            dataGridView1.Columns[0].HeaderText = "车主ID";
            dataGridView1.Columns[1].HeaderText = "车主姓名";
            dataGridView1.Columns[2].HeaderText = "标记原因";
            dataGridView1.Columns[3].HeaderText = "标记时间";
            dataGridView1.Columns[4].HeaderText = "操作员";
            dataGridView1.Columns[5].HeaderText = "备注";

            database.dbConn.Close();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string licensePlate = txtLicensePlateNum.Text;
            string ownerID = txtOwnerID.Text;
            string select = null;
            string delete = null;

            if (licensePlate == string.Empty && ownerID == string.Empty)
            {
                DialogResult result1 = MessageBox.Show("查询条件不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result1 == DialogResult.OK)
                {
                    txtLicensePlateNum.Focus();
                }
            }
            else if (licensePlate != string.Empty && ownerID != string.Empty)
            {
                DialogResult result2 = MessageBox.Show("只能输入一个查询条件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    txtLicensePlateNum.Focus();
                }
            }
            else
            {
                if (licensePlate == string.Empty)    // 输入了车主ID
                {
                    select = $"select * from INOwnerBlacklist where OwnerID = '{ownerID}'";
                    OleDbDataAdapter inst_id = new OleDbDataAdapter(select, database.dbConn);
                    DataTable dt_id = new DataTable();
                    inst_id.Fill(dt_id);
                    if (dt_id.Rows.Count == 0)
                    {
                        DialogResult result3 = MessageBox.Show("未查询到该ID", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result3 == DialogResult.OK)
                        {
                            txtOwnerID.Focus();
                        }
                    }
                    else
                    {
                        delete = $"delete from INOwnerBlacklist where OwnerID = '{ownerID}'";
                        OleDbCommand cmd_owner = new OleDbCommand(delete, database.dbConn);
                        cmd_owner.ExecuteNonQuery();
                        DialogResult result5 = MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result5 == DialogResult.OK)
                        {
                            txtOwnerID.Focus();
                        }
                    }
                }
                else    // 输入了车牌号
                {
                    select = $"select * from INVehicleBlacklist where VehicleNum = '{licensePlate}'";
                    OleDbDataAdapter inst_num = new OleDbDataAdapter(select, database.dbConn);
                    DataTable dt_num = new DataTable();
                    inst_num.Fill(dt_num);
                    if (dt_num.Rows.Count == 0)
                    {
                        DialogResult result4 = MessageBox.Show("未查询到该ID", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result4 == DialogResult.OK)
                        {
                            txtOwnerID.Focus();
                        }
                    }
                    else
                    {
                        delete = $"delete from INVehicleBlacklist where VehicleNum = '{licensePlate}'";
                        OleDbCommand cmd_vehicle = new OleDbCommand(delete, database.dbConn);
                        cmd_vehicle.ExecuteNonQuery();
                        DialogResult result6 = MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result6 == DialogResult.OK)
                        {
                            txtOwnerID.Focus();
                        }
                    }
                }
            }

            database.dbConn.Close();
        }
    }
}
