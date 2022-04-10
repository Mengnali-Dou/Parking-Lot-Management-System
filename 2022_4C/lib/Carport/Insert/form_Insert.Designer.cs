namespace _2022_4C.lib.Carport.Insert
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
            this.txtParkNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combPSType = new System.Windows.Forms.ComboBox();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numbers = new System.Windows.Forms.NumericUpDown();
            this.txtPark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numbers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParkNum
            // 
            this.txtParkNum.Location = new System.Drawing.Point(165, 86);
            this.txtParkNum.Name = "txtParkNum";
            this.txtParkNum.Size = new System.Drawing.Size(189, 27);
            this.txtParkNum.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "停车区编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "车位类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "备注：";
            // 
            // combPSType
            // 
            this.combPSType.FormattingEnabled = true;
            this.combPSType.Items.AddRange(new object[] {
            "临时车位",
            "固定车位",
            "特殊车位"});
            this.combPSType.Location = new System.Drawing.Point(165, 148);
            this.combPSType.Name = "combPSType";
            this.combPSType.Size = new System.Drawing.Size(189, 25);
            this.combPSType.TabIndex = 26;
            // 
            // rtxtComment
            // 
            this.rtxtComment.Location = new System.Drawing.Point(165, 259);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(189, 96);
            this.rtxtComment.TabIndex = 27;
            this.rtxtComment.Text = "";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(142, 391);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(155, 58);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "添加数量：";
            // 
            // numbers
            // 
            this.numbers.Location = new System.Drawing.Point(165, 205);
            this.numbers.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(189, 27);
            this.numbers.TabIndex = 30;
            this.numbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPark
            // 
            this.txtPark.Location = new System.Drawing.Point(165, 34);
            this.txtPark.Name = "txtPark";
            this.txtPark.Size = new System.Drawing.Size(189, 27);
            this.txtPark.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "停车场编号：";
            // 
            // form_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 487);
            this.Controls.Add(this.txtPark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rtxtComment);
            this.Controls.Add(this.combPSType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParkNum);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加停车位";
            ((System.ComponentModel.ISupportInitialize)(this.numbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParkNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combPSType;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numbers;
        private System.Windows.Forms.TextBox txtPark;
        private System.Windows.Forms.Label label5;
    }
}