namespace _2022_4C.lib.Blacklist
{
    partial class uc_insertSonVehicle
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
            this.txtPlateLicense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtReason = new System.Windows.Forms.RichTextBox();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号：";
            // 
            // txtPlateLicense
            // 
            this.txtPlateLicense.Location = new System.Drawing.Point(138, 34);
            this.txtPlateLicense.Name = "txtPlateLicense";
            this.txtPlateLicense.Size = new System.Drawing.Size(187, 27);
            this.txtPlateLicense.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "标记原因：";
            // 
            // rtxtReason
            // 
            this.rtxtReason.Location = new System.Drawing.Point(138, 82);
            this.rtxtReason.Name = "rtxtReason";
            this.rtxtReason.Size = new System.Drawing.Size(187, 96);
            this.rtxtReason.TabIndex = 3;
            this.rtxtReason.Text = "";
            // 
            // rtxtComment
            // 
            this.rtxtComment.Location = new System.Drawing.Point(138, 197);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(187, 100);
            this.rtxtComment.TabIndex = 5;
            this.rtxtComment.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "备注：";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(113, 369);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(158, 52);
            this.btn.TabIndex = 6;
            this.btn.Text = "标记";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(138, 319);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(187, 27);
            this.txtOperator.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "操作员：";
            // 
            // uc_insertSonVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.rtxtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlateLicense);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "uc_insertSonVehicle";
            this.Size = new System.Drawing.Size(393, 456);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlateLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtReason;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label label4;
    }
}
