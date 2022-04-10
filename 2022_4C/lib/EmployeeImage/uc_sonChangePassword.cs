using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_4C.lib.EmployeeImage
{
    public partial class uc_sonChangePassword : UserControl
    {
        public uc_ChangeEmployee form_CE;
        public uc_ChangeThis form_CT;

        public uc_sonChangePassword()
        {
            InitializeComponent();
        }

        private void btnUpdataThis_Click(object sender, EventArgs e)
        {
            form_CT.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_CT);
        }

        private void uc_sonChangePassword_Load(object sender, EventArgs e)
        {
            form_CE = new uc_ChangeEmployee();
            form_CT = new uc_ChangeThis();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            form_CE.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_CE);
        }
    }
}
