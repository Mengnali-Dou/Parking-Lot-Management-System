namespace _2022_4C.lib.Park.Insert
{
    partial class form_disSonUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_disSonUpdate));
            this.txtPANum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPSystemNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPASystemNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPANum
            // 
            this.txtPANum.Location = new System.Drawing.Point(186, 120);
            this.txtPANum.Name = "txtPANum";
            this.txtPANum.Size = new System.Drawing.Size(212, 27);
            this.txtPANum.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "停车区编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "停车区系统编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "备注：";
            // 
            // txtPSystemNum
            // 
            this.txtPSystemNum.Location = new System.Drawing.Point(186, 196);
            this.txtPSystemNum.Name = "txtPSystemNum";
            this.txtPSystemNum.Size = new System.Drawing.Size(212, 27);
            this.txtPSystemNum.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "停车场系统编号：";
            // 
            // rtxtComment
            // 
            this.rtxtComment.Location = new System.Drawing.Point(126, 267);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(272, 108);
            this.rtxtComment.TabIndex = 37;
            this.rtxtComment.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 417);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 56);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "确定";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPASystemNum
            // 
            this.txtPASystemNum.Location = new System.Drawing.Point(186, 49);
            this.txtPASystemNum.Name = "txtPASystemNum";
            this.txtPASystemNum.Size = new System.Drawing.Size(212, 27);
            this.txtPASystemNum.TabIndex = 39;
            // 
            // form_disSonUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 520);
            this.Controls.Add(this.txtPASystemNum);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtxtComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPSystemNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPANum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_disSonUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.form_disSonUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPANum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPSystemNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPASystemNum;
    }
}