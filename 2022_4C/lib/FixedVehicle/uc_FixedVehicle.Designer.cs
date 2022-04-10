namespace _2022_4C.lib.FixedVehicle
{
    partial class uc_FixedVehicle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIdleRent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1509, 843);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 30F);
            this.label1.Location = new System.Drawing.Point(114, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "日志";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIdleRent);
            this.panel1.Location = new System.Drawing.Point(3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 744);
            this.panel1.TabIndex = 8;
            // 
            // btnIdleRent
            // 
            this.btnIdleRent.Font = new System.Drawing.Font("宋体", 10F);
            this.btnIdleRent.Location = new System.Drawing.Point(58, 491);
            this.btnIdleRent.Name = "btnIdleRent";
            this.btnIdleRent.Size = new System.Drawing.Size(231, 54);
            this.btnIdleRent.TabIndex = 23;
            this.btnIdleRent.Text = "闲时出租日志";
            this.btnIdleRent.UseVisualStyleBackColor = true;
            this.btnIdleRent.Click += new System.EventHandler(this.btnIdleRent_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(366, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1509, 843);
            this.panel2.TabIndex = 9;
            // 
            // uc_FixedVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "uc_FixedVehicle";
            this.Size = new System.Drawing.Size(1878, 872);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIdleRent;
        private System.Windows.Forms.Panel panel2;
    }
}
