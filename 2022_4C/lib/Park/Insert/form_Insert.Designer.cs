namespace _2022_4C.lib.Park.Insert
{
    partial class form_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Insert));
            this.txtParkingSpot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParkingSpot
            // 
            this.txtParkingSpot.Location = new System.Drawing.Point(137, 110);
            this.txtParkingSpot.Name = "txtParkingSpot";
            this.txtParkingSpot.Size = new System.Drawing.Size(189, 27);
            this.txtParkingSpot.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "名称：";
            // 
            // txtPark
            // 
            this.txtPark.Location = new System.Drawing.Point(137, 47);
            this.txtPark.Name = "txtPark";
            this.txtPark.Size = new System.Drawing.Size(189, 27);
            this.txtPark.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "系统编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "备注：";
            // 
            // rtxtComment
            // 
            this.rtxtComment.Location = new System.Drawing.Point(137, 174);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(189, 96);
            this.rtxtComment.TabIndex = 31;
            this.rtxtComment.Text = "";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(137, 306);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 47);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // form_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 398);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rtxtComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParkingSpot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPark);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Insert";
            this.Text = "添加停车场";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParkingSpot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private System.Windows.Forms.Button btnInsert;
    }
}