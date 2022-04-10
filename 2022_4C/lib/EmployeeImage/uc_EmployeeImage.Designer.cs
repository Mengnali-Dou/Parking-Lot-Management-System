namespace _2022_4C.lib.EmployeeImage
{
    partial class uc_EmployeeImage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassWord = new System.Windows.Forms.Button();
            this.btnExpend = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnAskForLeave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 30F);
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "员工信息管理";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangePassWord);
            this.panel1.Controls.Add(this.btnExpend);
            this.panel1.Controls.Add(this.btnAttendance);
            this.panel1.Controls.Add(this.btnAskForLeave);
            this.panel1.Location = new System.Drawing.Point(3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 744);
            this.panel1.TabIndex = 20;
            // 
            // btnChangePassWord
            // 
            this.btnChangePassWord.Font = new System.Drawing.Font("宋体", 10F);
            this.btnChangePassWord.Location = new System.Drawing.Point(63, 466);
            this.btnChangePassWord.Name = "btnChangePassWord";
            this.btnChangePassWord.Size = new System.Drawing.Size(231, 54);
            this.btnChangePassWord.TabIndex = 23;
            this.btnChangePassWord.Text = "修改密码";
            this.btnChangePassWord.UseVisualStyleBackColor = true;
            this.btnChangePassWord.Click += new System.EventHandler(this.btnChangePassWord_Click);
            // 
            // btnExpend
            // 
            this.btnExpend.Font = new System.Drawing.Font("宋体", 10F);
            this.btnExpend.Location = new System.Drawing.Point(63, 386);
            this.btnExpend.Name = "btnExpend";
            this.btnExpend.Size = new System.Drawing.Size(231, 54);
            this.btnExpend.TabIndex = 22;
            this.btnExpend.Text = "报销";
            this.btnExpend.UseVisualStyleBackColor = true;
            this.btnExpend.Click += new System.EventHandler(this.btnExpend_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAttendance.Location = new System.Drawing.Point(63, 304);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(231, 54);
            this.btnAttendance.TabIndex = 21;
            this.btnAttendance.Text = "考勤";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnAskForLeave
            // 
            this.btnAskForLeave.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAskForLeave.Location = new System.Drawing.Point(63, 224);
            this.btnAskForLeave.Name = "btnAskForLeave";
            this.btnAskForLeave.Size = new System.Drawing.Size(231, 54);
            this.btnAskForLeave.TabIndex = 20;
            this.btnAskForLeave.Text = "请假";
            this.btnAskForLeave.UseVisualStyleBackColor = true;
            this.btnAskForLeave.Click += new System.EventHandler(this.btnAskForLeave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(366, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1509, 842);
            this.panel2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1509, 843);
            this.dataGridView1.TabIndex = 4;
            // 
            // uc_EmployeeImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "uc_EmployeeImage";
            this.Size = new System.Drawing.Size(1878, 872);
            this.Load += new System.EventHandler(this.uc_EmployeeImage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePassWord;
        private System.Windows.Forms.Button btnExpend;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnAskForLeave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
