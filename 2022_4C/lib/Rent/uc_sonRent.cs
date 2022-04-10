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

namespace _2022_4C.lib.Rent
{
    public partial class uc_sonRent : UserControl
    {
        public uc_sonRent()
        {
            InitializeComponent();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            form_RentOut form1 = new form_RentOut();
            form1.ShowDialog();
        }

        private void btnEndRent_Click(object sender, EventArgs e)
        {
            form_StopRent form2 = new form_StopRent();
            form2.ShowDialog();
        }

        private void btnSelectOrderForm_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            string select = "select * from OFIdleRent";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单号";
            dataGridView1.Columns[1].HeaderText = "车位系统编号";
            dataGridView1.Columns[2].HeaderText = "离开时间";
            dataGridView1.Columns[3].HeaderText = "停放时间";
            dataGridView1.Columns[4].HeaderText = "时长";
            dataGridView1.Columns[5].HeaderText = "费用";
            dataGridView1.Columns[6].HeaderText = "备注";
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            database.dbConn.Close();
        }
    }
}
