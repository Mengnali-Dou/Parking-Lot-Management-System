using _2022_4C.lib.FixedVehicle;
using _2022_4C.lib.TemVehicle.Enter;
using _2022_4C.lib.TemVehicle.FixVehicle;
using _2022_4C.lib.TemVehicle.TemVehicle;
using _2022_4C.lib.TemVehicle.UnVehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C.lib.TemVehicle
{
    public partial class uc_TemVehicle : UserControl
    {
        public uc_Enter uc_EN;
        public uc_Exit uc_EX;
        public uc_TemporaryVehicle uc_TE;
        public uc_UnlicensedVehicle uc_UV;
        public FixVehicle.uc_FixedVehicle uc_FI;
        public uc_sonEnterExit uc_EE;

        public uc_TemVehicle()
        {
            InitializeComponent();
            uc_EN = new uc_Enter();
            uc_EX = new uc_Exit();
            uc_TE = new uc_TemporaryVehicle();
            uc_UV = new uc_UnlicensedVehicle();
            uc_FI = new FixVehicle.uc_FixedVehicle();
            uc_EE = new uc_sonEnterExit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            uc_EN.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_EN);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            uc_EX.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_EX);
        }

        private void btnTemVehicle_Click(object sender, EventArgs e)
        {
            uc_TE.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_TE);
        }

        private void btnUnVehicle_Click(object sender, EventArgs e)
        {
            uc_UV.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_UV);
        }

        private void btnFixedVehicle_Click(object sender, EventArgs e)
        {
            uc_FI.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_FI);
        }

        private void btnEnterExit_Click(object sender, EventArgs e)
        {
            uc_EE.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_EE);
        }
    }
}
