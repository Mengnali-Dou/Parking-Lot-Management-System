using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C.lib.FixedVehicle
{
    public partial class uc_FixedVehicle : UserControl
    {
        //public uc_sonParkSpotLog uc_PS;
        public uc_sonParkLog uc_PA;
        public uc_sonIdleRentLog uc_IR;
        //public uc_sonEnterExit uc_EE;

        public uc_FixedVehicle()
        {
            InitializeComponent();
            //uc_PS = new uc_sonParkSpotLog();
            uc_PA = new uc_sonParkLog();
            uc_IR = new uc_sonIdleRentLog();
            //uc_EE = new uc_sonEnterExit();
        }

        private void btnIdleRent_Click(object sender, EventArgs e)
        {
            uc_IR.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_IR);
        }
    }
}
