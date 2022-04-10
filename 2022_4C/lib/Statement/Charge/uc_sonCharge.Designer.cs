namespace _2022_4C.lib.Statement.Charge
{
    partial class uc_sonCharge
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
            this.btnVehicleCharge = new System.Windows.Forms.Button();
            this.btnRates = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnVehicleCharge);
            this.groupBox1.Controls.Add(this.btnRates);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(25, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 589);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息管理";
            // 
            // btnVehicleCharge
            // 
            this.btnVehicleCharge.Font = new System.Drawing.Font("宋体", 10F);
            this.btnVehicleCharge.Location = new System.Drawing.Point(55, 321);
            this.btnVehicleCharge.Name = "btnVehicleCharge";
            this.btnVehicleCharge.Size = new System.Drawing.Size(231, 54);
            this.btnVehicleCharge.TabIndex = 23;
            this.btnVehicleCharge.Text = "车辆收费";
            this.btnVehicleCharge.UseVisualStyleBackColor = true;
            this.btnVehicleCharge.Click += new System.EventHandler(this.btnVehicleCharge_Click);
            // 
            // btnRates
            // 
            this.btnRates.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRates.Location = new System.Drawing.Point(55, 235);
            this.btnRates.Name = "btnRates";
            this.btnRates.Size = new System.Drawing.Size(231, 54);
            this.btnRates.TabIndex = 22;
            this.btnRates.Text = "收费标准";
            this.btnRates.UseVisualStyleBackColor = true;
            this.btnRates.Click += new System.EventHandler(this.btnRates_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(398, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 132);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(398, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 589);
            this.panel2.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 589);
            this.dataGridView1.TabIndex = 32;
            // 
            // uc_sonCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "uc_sonCharge";
            this.Size = new System.Drawing.Size(1509, 843);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVehicleCharge;
        private System.Windows.Forms.Button btnRates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
