using _2022_4C.lib.FixedVehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C.lib.Rent
{
    public partial class uc_Rent : UserControl
    {
        public uc_sonIdleRentLog uc_IR;
        public uc_sonRent uc_SR;

        public uc_Rent()
        {
            InitializeComponent();
            uc_IR = new uc_sonIdleRentLog();
            uc_SR = new uc_sonRent();
        }

        private void btnIdleRent_Click(object sender, EventArgs e)
        {
            uc_IR.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_IR);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            uc_SR.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_SR);
        }
    }
}
