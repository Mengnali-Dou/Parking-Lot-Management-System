using _2022_4C.data;
using _2022_4C.lib.Accident;
using _2022_4C.lib.Carport;
using _2022_4C.lib.EmployeeImage.forEmployee;
using _2022_4C.lib.Park;
using _2022_4C.lib.Repairs;
using _2022_4C.lib.TemVehicle;
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

namespace _2022_4C
{
    public partial class FormMainEmployee : Form
    {
        public uc_Carport form_cp;
        public uc_Park form_pa;
        public uc_TemVehicle form_te;
        public uc_Accident form_ac;
        public uc_Repairs form_re;
        public uc_mainImage uc_MI;

        public FormMainEmployee()
        {
            InitializeComponent();
        }

        private void FormMainEmployee_Load(object sender, EventArgs e)
        {
            form_cp = new uc_Carport();
            form_pa = new uc_Park();
            form_te = new uc_TemVehicle();
            form_ac = new uc_Accident();
            form_re = new uc_Repairs();
            uc_MI = new uc_mainImage();

            // 设置抬头初始时间
            this.toolStripStatusLabel4.Text = "登陆时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");    // 登陆时间
            this.toolStripStatusLabel5.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.toolStripStatusLabel2.Text = "员工";

            // 头部操作员
            string select_name = "select PersonalName from Cache where Num = 1";
            OleDbDataAdapter inst1 = new OleDbDataAdapter(select_name, database.dbConn);
            DataTable dt1 = new DataTable();
            inst1.Fill(dt1);
            string name = dt1.Rows[0][0].ToString();
            this.toolStripStatusLabel3.Text = "操作员：" + name;

            timer1.Interval = 1000;    // 时间间隔一秒
            timer1.Start();    // 启用定时器

            // 窗体全屏
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;    // 隐藏窗口边框
            //int w = System.Windows.Forms.SystemInformation.VirtualScreen.Width;    // 获取屏幕的宽度和高度
            //int h = System.Windows.Forms.SystemInformation.VirtualScreen.Height;
            //this.MaximumSize = new Size(w, h);    // 设置最大尺寸和最小尺寸
            //this.MinimumSize = new Size(w, h);
            //this.Location = new Point(0, 0);    // 设置窗口位置
            //this.Width = w;    // 设置窗口大小
            //this.Height = h;
            //this.TopMost = true;    // 置顶显示
        }

        /// <summary>
        /// 触发定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 更新时间
            this.toolStripStatusLabel5.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnEmployeeImage_Click(object sender, EventArgs e)
        {
            // TODO:个人信息管理
            uc_MI.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_MI);
        }

        /// <summary>
        /// 车位管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarport_Click(object sender, EventArgs e)
        {
            form_cp.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_cp);
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            form_pa.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_pa);
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            form_te.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_te);
        }

        private void btnRepairs_Click(object sender, EventArgs e)
        {
            form_re.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_re);
        }

        private void btnAccident_Click(object sender, EventArgs e)
        {
            form_ac.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_ac);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("确定要退出登录？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog1 == DialogResult.OK)
            {
                database.dbConn.Open();

                string select_ASNum = $"select ASNum from Cache where Num = 1";
                OleDbDataAdapter inst1 = new OleDbDataAdapter(select_ASNum, database.dbConn);
                DataTable dt1 = new DataTable();
                inst1.Fill(dt1);
                string ASNum = dt1.Rows[0][0].ToString();

                string time = DateTime.Now.ToString();
                string update_Attendance = $"update BAAttendanceSheet set OffDutyTime = '{time}' where ASNum = '{ASNum}'";
                OleDbCommand cmd = new OleDbCommand(update_Attendance, database.dbConn);
                cmd.ExecuteNonQuery();

                database.dbConn.Close();

                Form1 form1 = new Form1();
                this.Close();
                form1.ShowDialog();
            }
        }
    }
}
