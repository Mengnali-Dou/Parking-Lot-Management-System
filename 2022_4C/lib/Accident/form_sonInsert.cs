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

namespace _2022_4C.lib.Accident
{
    public partial class form_sonInsert : Form
    {
        public form_sonInsert()
        {
            InitializeComponent();
        }

        public string Date()
        {
            DateTime dt = DateTime.Now;
            string date = dt.ToShortDateString().ToString();
            return date;
        }

        private void form_sonInsert_Load(object sender, EventArgs e)
        {
            labTime.Text = Date();
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            database.dbConn.Open();

            
            string date = Date();
            string type = txtType.Text;
            string place = rtxtPlace.Text;
            string name = txtName.Text;
            string tel = txtTel.Text;
            string traffic = "否";
            string comment = rtxtComment.Text;
            string insert = null;
            string park = txtPark.Text;

            if (type == string.Empty || place == string.Empty || name == string.Empty || tel == string.Empty || park == string.Empty)
            {
                DialogResult dialog = MessageBox.Show("除备注外不能有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    txtName.Focus();
                }
            }
            else
            {
                string num = GrenerateTraNum.TraNum(park);

                insert = $"insert into TRVehicleTraffic (TraNum,TraDate,TraType,TraPlace,OwnerName,OwnerTel,Traffic,TraComment) values ('{num}','{date}','{type}','{place}','{name}','{tel}','{traffic}','{comment}')";
                OleDbCommand myCommand = new OleDbCommand(insert, database.dbConn);
                myCommand.ExecuteNonQuery();
                DialogResult dialog = MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                    database.dbConn.Close();
                }
            }

            database.dbConn.Close();
        }
    }
}
