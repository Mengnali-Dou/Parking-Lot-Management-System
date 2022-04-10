using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C.lib.Blacklist
{
    public partial class form_Insert : Form
    {
        private uc_insertSonVehicle uc_vehicle;
        private uc_insertSonOwner uc_owner;

        public form_Insert()
        {
            InitializeComponent();
            uc_vehicle = new uc_insertSonVehicle();
            uc_owner = new uc_insertSonOwner();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            uc_vehicle.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_vehicle);
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            uc_owner.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_owner);
        }
    }
}
