using _2022_4C.lib.Statement.Charge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C.lib.Statement
{
    public partial class uc_Statement : UserControl
    {
        public uc_sonOrderForm uc_OF;
        public uc_sonCharge uc_CH;
        public uc_sonExpend uc_EX;
        public uc_sonFiance uc_FI;
        public uc_sonEqu uc_EQ;
        public uc_Engineering uc_EN;

        public uc_Statement()
        {
            InitializeComponent();
            uc_OF = new uc_sonOrderForm();
            uc_CH = new uc_sonCharge();
            uc_EX = new uc_sonExpend();
            uc_FI = new uc_sonFiance();
            uc_EQ = new uc_sonEqu();
            uc_EN = new uc_Engineering();
        }

        private void btnOederForm_Click(object sender, EventArgs e)
        {
            uc_OF.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_OF);
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            uc_CH.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_CH);
        }

        private void btnExpend_Click(object sender, EventArgs e)
        {
            uc_EX.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_EX);
        }

        private void btnFinancialStatement_Click(object sender, EventArgs e)
        {
            uc_FI.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_FI);
        }

        private void btnEquPro_Click(object sender, EventArgs e)
        {
            uc_EQ.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_EQ);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            uc_EN.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(uc_EN);
        }
    }
}
