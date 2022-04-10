namespace _2022_4C.lib.EmployeeImage
{
    partial class uc_ChangeEmployee
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
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPd2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateThis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(174, 177);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(200, 25);
            this.txtEmployeeID.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "员工ID：";
            // 
            // txtNewPD
            // 
            this.txtNewPD.Location = new System.Drawing.Point(174, 238);
            this.txtNewPD.Name = "txtNewPD";
            this.txtNewPD.Size = new System.Drawing.Size(200, 25);
            this.txtNewPD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "新密码：";
            // 
            // txtNewPd2
            // 
            this.txtNewPd2.Location = new System.Drawing.Point(174, 298);
            this.txtNewPd2.Name = "txtNewPd2";
            this.txtNewPd2.Size = new System.Drawing.Size(200, 25);
            this.txtNewPd2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "重新输入：";
            // 
            // btnUpdateThis
            // 
            this.btnUpdateThis.Font = new System.Drawing.Font("宋体", 10F);
            this.btnUpdateThis.Location = new System.Drawing.Point(527, 220);
            this.btnUpdateThis.Name = "btnUpdateThis";
            this.btnUpdateThis.Size = new System.Drawing.Size(231, 54);
            this.btnUpdateThis.TabIndex = 33;
            this.btnUpdateThis.Text = "修改当前账户密码";
            this.btnUpdateThis.UseVisualStyleBackColor = true;
            this.btnUpdateThis.Click += new System.EventHandler(this.btnUpdateThis_Click);
            // 
            // uc_ChangeEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnUpdateThis);
            this.Controls.Add(this.txtNewPd2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label4);
            this.Name = "uc_ChangeEmployee";
            this.Size = new System.Drawing.Size(983, 589);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPd2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateThis;
    }
}
