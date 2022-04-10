using _2022_4C.data;
using _2022_4C.lib.Carport.Insert;
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

namespace _2022_4C.lib.Carport
{
    public partial class uc_Carport : UserControl
    {
        public uc_Carport()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(dataGridView1);

            // TODO:从这儿开始，停车位的
            database.dbConn.Open();

            string area = txtArea.Text;
            string spot = txtSpot.Text;
            string select = null;

            if (area == string.Empty && spot == string.Empty)
            {
                select = "select * from PAParkingSpot";
            }
            else if (area != string.Empty && spot == string.Empty)
            {
                select = $"select * from PAParkingSpot where PANum = '{area}'";
            }
            else if (spot != string.Empty)
            {
                select = $"select * from PAParkingSpot where PSSystemNum = '{spot}'";
            }
            OleDbDataAdapter myCommand = new OleDbDataAdapter(@select, database.dbConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "停车位系统编号";
            dataGridView1.Columns[1].HeaderText = "停车位编号";
            dataGridView1.Columns[2].HeaderText = "停车区系统编号";
            dataGridView1.Columns[3].HeaderText = "车位类型";
            dataGridView1.Columns[4].HeaderText = "备注";
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
