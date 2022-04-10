namespace _2022_4C.lib.Statement.Charge
{
    partial class uc_sonExpend
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
            this.btnReturnRent = new System.Windows.Forms.Button();
            this.btnDisbursement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnReturnRent);
            this.groupBox1.Controls.Add(this.btnDisbursement);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(25, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 589);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息管理";
            // 
            // btnReturnRent
            // 
            this.btnReturnRent.Font = new System.Drawing.Font("宋体", 10F);
            this.btnReturnRent.Location = new System.Drawing.Point(52, 311);
            this.btnReturnRent.Name = "btnReturnRent";
            this.btnReturnRent.Size = new System.Drawing.Size(231, 54);
            this.btnReturnRent.TabIndex = 26;
            this.btnReturnRent.Text = "闲时出租租金返还";
            this.btnReturnRent.UseVisualStyleBackColor = true;
            this.btnReturnRent.Click += new System.EventHandler(this.btnReturnRent_Click);
            // 
            // btnDisbursement
            // 
            this.btnDisbursement.Font = new System.Drawing.Font("宋体", 10F);
            this.btnDisbursement.Location = new System.Drawing.Point(52, 220);
            this.btnDisbursement.Name = "btnDisbursement";
            this.btnDisbursement.Size = new System.Drawing.Size(231, 54);
            this.btnDisbursement.TabIndex = 24;
            this.btnDisbursement.Text = "支出费用";
            this.btnDisbursement.UseVisualStyleBackColor = true;
            this.btnDisbursement.Click += new System.EventHandler(this.btnDisbursement_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(398, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 132);
            this.panel1.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 589);
            this.dataGridView1.TabIndex = 35;
            // 
            // uc_sonExpend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "uc_sonExpend";
            this.Size = new System.Drawing.Size(1509, 843);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReturnRent;
        private System.Windows.Forms.Button btnDisbursement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
