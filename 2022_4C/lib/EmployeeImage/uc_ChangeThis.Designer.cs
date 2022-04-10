namespace _2022_4C.lib.EmployeeImage
{
    partial class uc_ChangeThis
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
            this.btnUpdateThis = new System.Windows.Forms.Button();
            this.txtNewPd2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateThis
            // 
            this.btnUpdateThis.Font = new System.Drawing.Font("宋体", 10F);
            this.btnUpdateThis.Location = new System.Drawing.Point(549, 229);
            this.btnUpdateThis.Name = "btnUpdateThis";
            this.btnUpdateThis.Size = new System.Drawing.Size(231, 54);
            this.btnUpdateThis.TabIndex = 40;
            this.btnUpdateThis.Text = "修改当前账户密码";
            this.btnUpdateThis.UseVisualStyleBackColor = true;
            this.btnUpdateThis.Click += new System.EventHandler(this.btnUpdateThis_Click);
            // 
            // txtNewPd2
            // 
            this.txtNewPd2.Location = new System.Drawing.Point(230, 305);
            this.txtNewPd2.Name = "txtNewPd2";
            this.txtNewPd2.Size = new System.Drawing.Size(200, 27);
            this.txtNewPd2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "重新输入：";
            // 
            // txtNewPD
            // 
            this.txtNewPD.Location = new System.Drawing.Point(230, 245);
            this.txtNewPD.Name = "txtNewPD";
            this.txtNewPD.Size = new System.Drawing.Size(200, 27);
            this.txtNewPD.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "新密码：";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(230, 188);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(200, 27);
            this.txtEmployeeID.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "员工ID：";
            // 
            // uc_ChangeThis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateThis);
            this.Controls.Add(this.txtNewPd2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "uc_ChangeThis";
            this.Size = new System.Drawing.Size(979, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateThis;
        private System.Windows.Forms.TextBox txtNewPd2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label4;
    }
}
