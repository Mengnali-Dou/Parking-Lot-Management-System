using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C.lib.TemVehicle.FixVehicle
{
    public partial class uc_sonOrderForm : UserControl
    {
        public uc_sonOrderForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            form_OrderFormInsert form1 = new form_OrderFormInsert();
            form1.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            form_OrderFormUpdate form2 = new form_OrderFormUpdate();
            form2.ShowDialog();
        }
    }
}
