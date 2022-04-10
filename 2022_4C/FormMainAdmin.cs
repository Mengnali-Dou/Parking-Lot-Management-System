using _2022_4C.data;
using _2022_4C.DB;
using _2022_4C.lib.Accident;
using _2022_4C.lib.Blacklist;
using _2022_4C.lib.Carport;
using _2022_4C.lib.EmployeeImage;
using _2022_4C.lib.FixedVehicle;
using _2022_4C.lib.Park;
using _2022_4C.lib.Rent;
using _2022_4C.lib.Repairs;
using _2022_4C.lib.Statement;
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
    public partial class FormMainAdmin : Form
    {
        //private MyDbContext MyDb = new MyDbContext();

        public uc_EmployeeImage form_ei;    // 创建员工信息控件变量
        public uc_Carport form_cp;    // 创建车位管理控件变量
        public uc_Accident form_ac;    // 创建事故处理控件变量
        public uc_Blacklist form_bl;    // 创建黑名单控件变量
        public uc_FixedVehicle form_fv;    // 创建日志按钮控件变量
        public uc_Park form_pa;    // 创建停车场按钮控件变量
        public uc_Repairs form_re;    // 创建报修按钮控件
        public uc_Statement form_st;    // 创建报表统计按钮控件
        public uc_TemVehicle form_te;    // 创建车辆控件变量
        public uc_Rent uc_re;

        public FormMainAdmin()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 控件变量实例化
            form_ei = new uc_EmployeeImage();
            form_cp = new uc_Carport();
            form_ac = new uc_Accident();
            form_bl = new uc_Blacklist();
            form_fv = new uc_FixedVehicle();
            form_pa = new uc_Park();
            form_re = new uc_Repairs();
            form_st = new uc_Statement();
            form_te = new uc_TemVehicle();
            uc_re = new uc_Rent();

            // 设置抬头初始时间
            this.toolStripStatusLabel4.Text = "登陆时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");    // 登陆时间
            this.toolStripStatusLabel5.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
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
        /// 退出登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 退出确认
            DialogResult dialog1 = MessageBox.Show("确定要退出登录？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog1 == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                this.Close();
                form1.ShowDialog();
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 触发定时器的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 更新时间
            this.toolStripStatusLabel5.Text = "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 员工信息管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployeeImage_Click(object sender, EventArgs e)
        {
            form_ei.Show();
            panel1.Controls.Clear();    // 清空容器上的控件
            panel1.Controls.Add(form_ei);    // 窗体加入容器
        }

        /// <summary>
        /// 车位信息管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarport_Click(object sender, EventArgs e)
        {
            form_cp.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_cp);
        }

        /// <summary>
        /// 停车场管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPark_Click(object sender, EventArgs e)
        {
            form_pa.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_pa);
        }

        /// <summary>
        /// 车辆管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTemVehicle_Click(object sender, EventArgs e)
        {
            form_te.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_te);
        }
        
        /// <summary>
        /// 日志按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFixedVehicle_Click(object sender, EventArgs e)
        {
            uc_re.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc_re);
        }

        /// <summary>
        /// 报表统计按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatement_Click(object sender, EventArgs e)
        {
            form_st.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_st);
        }

        /// <summary>
        /// 报修按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRepairs_Click(object sender, EventArgs e)
        {
            form_re.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_re);
        }

        /// <summary>
        /// 事故处理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccident_Click(object sender, EventArgs e)
        {
            form_ac.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_ac);
        }

        /// <summary>
        /// 黑名单按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            form_bl.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(form_bl);
        }
    }
}
