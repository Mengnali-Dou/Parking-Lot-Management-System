namespace _2022_4C.lib.EmployeeImage
{
    partial class uc_sonChangePassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnUpdataThis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnUpdateEmployee);
            this.groupBox1.Controls.Add(this.btnUpdataThis);
            this.groupBox1.Location = new System.Drawing.Point(25, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 589);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Font = new System.Drawing.Font("宋体", 10F);
            this.btnUpdateEmployee.Location = new System.Drawing.Point(52, 348);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(231, 54);
            this.btnUpdateEmployee.TabIndex = 34;
            this.btnUpdateEmployee.Text = "修改员工密码";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnUpdataThis
            // 
            this.btnUpdataThis.Font = new System.Drawing.Font("宋体", 10F);
            this.btnUpdataThis.Location = new System.Drawing.Point(52, 251);
            this.btnUpdataThis.Name = "btnUpdataThis";
            this.btnUpdataThis.Size = new System.Drawing.Size(231, 54);
            this.btnUpdataThis.TabIndex = 29;
            this.btnUpdataThis.Text = "修改当前账户密码";
            this.btnUpdataThis.UseVisualStyleBackColor = true;
            this.btnUpdataThis.Click += new System.EventHandler(this.btnUpdataThis_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(505, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 589);
            this.panel1.TabIndex = 3;
            // 
            // uc_sonChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_sonChangePassword";
            this.Size = new System.Drawing.Size(1505, 839);
            this.Load += new System.EventHandler(this.uc_sonChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnUpdataThis;
        private System.Windows.Forms.Panel panel1;
    }
}
