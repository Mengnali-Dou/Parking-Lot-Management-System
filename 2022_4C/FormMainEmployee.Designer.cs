namespace _2022_4C
{
    partial class FormMainEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainEmployee));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAccident = new System.Windows.Forms.Button();
            this.btnRepairs = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnPark = new System.Windows.Forms.Button();
            this.btnCarport = new System.Windows.Forms.Button();
            this.btnEmployeeImage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1902, 35);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(369, 29);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "欢迎使用云车位管理系统";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(369, 29);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "管理员";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(369, 29);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "操作员：admin01";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(369, 29);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.Text = "登陆时间：";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(369, 29);
            this.toolStripStatusLabel5.Spring = true;
            this.toolStripStatusLabel5.Text = "当前时间：";
            // 
            // btnAccident
            // 
            this.btnAccident.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAccident.Location = new System.Drawing.Point(766, 93);
            this.btnAccident.Name = "btnAccident";
            this.btnAccident.Size = new System.Drawing.Size(371, 49);
            this.btnAccident.TabIndex = 16;
            this.btnAccident.Text = "用户反馈";
            this.btnAccident.UseVisualStyleBackColor = true;
            this.btnAccident.Click += new System.EventHandler(this.btnAccident_Click);
            // 
            // btnRepairs
            // 
            this.btnRepairs.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRepairs.Location = new System.Drawing.Point(389, 93);
            this.btnRepairs.Name = "btnRepairs";
            this.btnRepairs.Size = new System.Drawing.Size(371, 49);
            this.btnRepairs.TabIndex = 15;
            this.btnRepairs.Text = "报修";
            this.btnRepairs.UseVisualStyleBackColor = true;
            this.btnRepairs.Click += new System.EventHandler(this.btnRepairs_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Font = new System.Drawing.Font("宋体", 10F);
            this.btnVehicle.Location = new System.Drawing.Point(766, 37);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(371, 49);
            this.btnVehicle.TabIndex = 14;
            this.btnVehicle.Text = "车辆管理";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnPark
            // 
            this.btnPark.Font = new System.Drawing.Font("宋体", 10F);
            this.btnPark.Location = new System.Drawing.Point(389, 37);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(371, 49);
            this.btnPark.TabIndex = 13;
            this.btnPark.Text = "停车场管理";
            this.btnPark.UseVisualStyleBackColor = true;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // btnCarport
            // 
            this.btnCarport.Font = new System.Drawing.Font("宋体", 10F);
            this.btnCarport.Location = new System.Drawing.Point(12, 38);
            this.btnCarport.Name = "btnCarport";
            this.btnCarport.Size = new System.Drawing.Size(371, 49);
            this.btnCarport.TabIndex = 12;
            this.btnCarport.Text = "车位管理";
            this.btnCarport.UseVisualStyleBackColor = true;
            this.btnCarport.Click += new System.EventHandler(this.btnCarport_Click);
            // 
            // btnEmployeeImage
            // 
            this.btnEmployeeImage.Font = new System.Drawing.Font("宋体", 10F);
            this.btnEmployeeImage.Location = new System.Drawing.Point(12, 93);
            this.btnEmployeeImage.Name = "btnEmployeeImage";
            this.btnEmployeeImage.Size = new System.Drawing.Size(370, 49);
            this.btnEmployeeImage.TabIndex = 11;
            this.btnEmployeeImage.Text = "个人信息管理";
            this.btnEmployeeImage.UseVisualStyleBackColor = true;
            this.btnEmployeeImage.Click += new System.EventHandler(this.btnEmployeeImage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10F);
            this.button1.Location = new System.Drawing.Point(1143, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "退出登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1878, 872);
            this.panel1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMainEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnEmployeeImage);
            this.Controls.Add(this.btnAccident);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRepairs);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.btnPark);
            this.Controls.Add(this.btnCarport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "云车位管理系统";
            this.Load += new System.EventHandler(this.FormMainEmployee_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Button btnAccident;
        private System.Windows.Forms.Button btnRepairs;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnPark;
        private System.Windows.Forms.Button btnCarport;
        private System.Windows.Forms.Button btnEmployeeImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}