namespace _2022_4C.lib.EmployeeImage.forEmployee
{
    partial class uc_mainImage
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
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnAskForLeave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.label1.TabIndex = 5;
            this.label1.Text = "个人信息管理";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangePassWord);
            this.panel1.Controls.Add(this.btnAttendance);
            this.panel1.Controls.Add(this.btnAskForLeave);
            this.panel1.Location = new System.Drawing.Point(3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 744);
            this.panel1.TabIndex = 21;
            // 
            // btnChangePassWord
            // 
            this.btnChangePassWord.Font = new System.Drawing.Font("宋体", 10F);
            this.btnChangePassWord.Location = new System.Drawing.Point(62, 424);
            this.btnChangePassWord.Name = "btnChangePassWord";
            this.btnChangePassWord.Size = new System.Drawing.Size(231, 54);
            this.btnChangePassWord.TabIndex = 23;
            this.btnChangePassWord.Text = "修改密码";
            this.btnChangePassWord.UseVisualStyleBackColor = true;
            this.btnChangePassWord.Click += new System.EventHandler(this.btnChangePassWord_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAttendance.Location = new System.Drawing.Point(62, 345);
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
            this.btnAskForLeave.Location = new System.Drawing.Point(62, 265);
            this.btnAskForLeave.Name = "btnAskForLeave";
            this.btnAskForLeave.Size = new System.Drawing.Size(231, 54);
            this.btnAskForLeave.TabIndex = 20;
            this.btnAskForLeave.Text = "请假";
            this.btnAskForLeave.UseVisualStyleBackColor = true;
            this.btnAskForLeave.Click += new System.EventHandler(this.btnAskForLeave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1509, 843);
            this.dataGridView1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Font = new System.Drawing.Font("宋体", 10F);
            this.panel2.Location = new System.Drawing.Point(366, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1509, 843);
            this.panel2.TabIndex = 23;
            // 
            // uc_mainImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "uc_mainImage";
            this.Size = new System.Drawing.Size(1878, 872);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePassWord;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnAskForLeave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
    }
}
