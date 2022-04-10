namespace _2022_4C.lib.TemVehicle.FixVehicle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFixedVehicle = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnOwner);
            this.groupBox1.Controls.Add(this.btnFixedVehicle);
            this.groupBox1.Controls.Add(this.btnVehicle);
            this.groupBox1.Controls.Add(this.btnOrderForm);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(25, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 589);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "固定车辆";
            // 
            // btnVehicle
            // 
            this.btnVehicle.Font = new System.Drawing.Font("宋体", 10F);
            this.btnVehicle.Location = new System.Drawing.Point(55, 315);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(231, 54);
            this.btnVehicle.TabIndex = 36;
            this.btnVehicle.Text = "在场车辆";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.Font = new System.Drawing.Font("宋体", 10F);
            this.btnOrderForm.Location = new System.Drawing.Point(55, 399);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.Size = new System.Drawing.Size(231, 54);
            this.btnOrderForm.TabIndex = 35;
            this.btnOrderForm.Text = "固定车辆订单";
            this.btnOrderForm.UseVisualStyleBackColor = true;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 589);
            this.dataGridView1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(398, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 132);
            this.panel1.TabIndex = 34;
            // 
            // btnFixedVehicle
            // 
            this.btnFixedVehicle.Font = new System.Drawing.Font("宋体", 10F);
            this.btnFixedVehicle.Location = new System.Drawing.Point(55, 226);
            this.btnFixedVehicle.Name = "btnFixedVehicle";
            this.btnFixedVehicle.Size = new System.Drawing.Size(231, 54);
            this.btnFixedVehicle.TabIndex = 37;
            this.btnFixedVehicle.Text = "固定车辆";
            this.btnFixedVehicle.UseVisualStyleBackColor = true;
            this.btnFixedVehicle.Click += new System.EventHandler(this.btnFixedVehicle_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Font = new System.Drawing.Font("宋体", 10F);
            this.btnOwner.Location = new System.Drawing.Point(55, 142);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(231, 54);
            this.btnOwner.TabIndex = 38;
            this.btnOwner.Text = "车主";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // uc_FixedVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "uc_FixedVehicle";
            this.Size = new System.Drawing.Size(1505, 839);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnOrderForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFixedVehicle;
        private System.Windows.Forms.Button btnOwner;
    }
}
