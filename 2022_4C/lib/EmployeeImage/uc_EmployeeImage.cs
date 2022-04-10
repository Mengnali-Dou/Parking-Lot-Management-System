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
    public partial class uc_EmployeeImage : UserControl
    {
        public uc_sonAskForLeave form_AFL;    // 创建员工请假控件变量
        public uc_sonChaekingIn form_CI;    // 创建考勤控件变量
        public uc_sonExpend form_EX;    // 创建报销控件变量
        public uc_sonChangePassword form_CP;    // 创建修改密码控件变量

        private void uc_EmployeeImage_Load(object sender, EventArgs e)
        {
            // 控件变量实例化
            form_AFL = new uc_sonAskForLeave();
            form_CI = new uc_sonChaekingIn();
            form_EX = new uc_sonExpend();
            form_CP = new uc_sonChangePassword();
        }

        public uc_EmployeeImage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 员工请假
        /// </summary>
        /// <param name="form_AFL">员工请假窗体</param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAskForLeave_Click(object sender, EventArgs e)
        {
            form_AFL.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(form_AFL);
        }

        /// <summary>
        /// 考勤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            form_CI.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(form_CI);
        }

        /// <summary>
        /// 报销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpend_Click(object sender, EventArgs e)
        {
            form_EX.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(form_EX);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            form_CP.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(form_CP);
        }
    }
}
