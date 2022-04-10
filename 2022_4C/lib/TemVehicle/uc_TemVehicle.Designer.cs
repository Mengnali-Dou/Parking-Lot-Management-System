namespace _2022_4C.lib.TemVehicle
{
    partial class uc_TemVehicle
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnVehicle = new System.Windows.Forms.Button();
            this.btnFixedVehicle = new System.Windows.Forms.Button();
            this.btnTemVehicle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnterExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1509, 843);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 30F);
            this.label1.Location = new System.Drawing.Point(67, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "车辆管理";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEnterExit);
            this.panel1.Controls.Add(this.btnUnVehicle);
            this.panel1.Controls.Add(this.btnFixedVehicle);
            this.panel1.Controls.Add(this.btnTemVehicle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 744);
            this.panel1.TabIndex = 9;
            // 
            // btnUnVehicle
            // 
            this.btnUnVehicle.Font = new System.Drawing.Font("宋体", 10F);
            this.btnUnVehicle.Location = new System.Drawing.Point(60, 472);
            this.btnUnVehicle.Name = "btnUnVehicle";
            this.btnUnVehicle.Size = new System.Drawing.Size(231, 54);
            this.btnUnVehicle.TabIndex = 26;
            this.btnUnVehicle.Text = "无牌车辆";
            this.btnUnVehicle.UseVisualStyleBackColor = true;
            this.btnUnVehicle.Click += new System.EventHandler(this.btnUnVehicle_Click);
            // 
            // btnFixedVehicle
            // 
            this.btnFixedVehicle.Font = new System.Drawing.Font("宋体", 10F);
            this.btnFixedVehicle.Location = new System.Drawing.Point(60, 383);
            this.btnFixedVehicle.Name = "btnFixedVehicle";
            this.btnFixedVehicle.Size = new System.Drawing.Size(231, 54);
            this.btnFixedVehicle.TabIndex = 25;
            this.btnFixedVehicle.Text = "固定车辆";
            this.btnFixedVehicle.UseVisualStyleBackColor = true;
            this.btnFixedVehicle.Click += new System.EventHandler(this.btnFixedVehicle_Click);
            // 
            // btnTemVehicle
            // 
            this.btnTemVehicle.Font = new System.Drawing.Font("宋体", 10F);
            this.btnTemVehicle.Location = new System.Drawing.Point(60, 293);
            this.btnTemVehicle.Name = "btnTemVehicle";
            this.btnTemVehicle.Size = new System.Drawing.Size(231, 54);
            this.btnTemVehicle.TabIndex = 24;
            this.btnTemVehicle.Text = "临时车辆";
            this.btnTemVehicle.UseVisualStyleBackColor = true;
            this.btnTemVehicle.Click += new System.EventHandler(this.btnTemVehicle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 10F);
            this.btnExit.Location = new System.Drawing.Point(188, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 54);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "车辆出场";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("宋体", 10F);
            this.btnEnter.Location = new System.Drawing.Point(60, 202);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(103, 54);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "车辆进场";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Font = new System.Drawing.Font("宋体", 10F);
            this.panel2.Location = new System.Drawing.Point(366, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1509, 843);
            this.panel2.TabIndex = 10;
            // 
            // btnEnterExit
            // 
            this.btnEnterExit.Font = new System.Drawing.Font("宋体", 10F);
            this.btnEnterExit.Location = new System.Drawing.Point(60, 559);
            this.btnEnterExit.Name = "btnEnterExit";
            this.btnEnterExit.Size = new System.Drawing.Size(231, 54);
            this.btnEnterExit.TabIndex = 27;
            this.btnEnterExit.Text = "车辆进出场日志";
            this.btnEnterExit.UseVisualStyleBackColor = true;
            this.btnEnterExit.Click += new System.EventHandler(this.btnEnterExit_Click);
            // 
            // uc_TemVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "uc_TemVehicle";
            this.Size = new System.Drawing.Size(1878, 872);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnTemVehicle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFixedVehicle;
        private System.Windows.Forms.Button btnUnVehicle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnterExit;
    }
}
