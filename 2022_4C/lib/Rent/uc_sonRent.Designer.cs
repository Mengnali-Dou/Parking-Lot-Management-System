
namespace _2022_4C.lib.Rent
{
    partial class uc_sonRent
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
            this.btnSelectOrderForm = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEndRent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnEndRent);
            this.groupBox1.Controls.Add(this.btnSelectOrderForm);
            this.groupBox1.Controls.Add(this.btnRent);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(25, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 589);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "闲时出租";
            // 
            // btnSelectOrderForm
            // 
            this.btnSelectOrderForm.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSelectOrderForm.Location = new System.Drawing.Point(57, 419);
            this.btnSelectOrderForm.Name = "btnSelectOrderForm";
            this.btnSelectOrderForm.Size = new System.Drawing.Size(231, 54);
            this.btnSelectOrderForm.TabIndex = 23;
            this.btnSelectOrderForm.Text = "查订单";
            this.btnSelectOrderForm.UseVisualStyleBackColor = true;
            this.btnSelectOrderForm.Click += new System.EventHandler(this.btnSelectOrderForm_Click);
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRent.Location = new System.Drawing.Point(57, 163);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(231, 54);
            this.btnRent.TabIndex = 21;
            this.btnRent.Text = "出租";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 589);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnEndRent
            // 
            this.btnEndRent.Font = new System.Drawing.Font("宋体", 10F);
            this.btnEndRent.Location = new System.Drawing.Point(57, 290);
            this.btnEndRent.Name = "btnEndRent";
            this.btnEndRent.Size = new System.Drawing.Size(231, 54);
            this.btnEndRent.TabIndex = 24;
            this.btnEndRent.Text = "结束出租";
            this.btnEndRent.UseVisualStyleBackColor = true;
            this.btnEndRent.Click += new System.EventHandler(this.btnEndRent_Click);
            // 
            // uc_sonRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "uc_sonRent";
            this.Size = new System.Drawing.Size(1505, 839);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectOrderForm;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEndRent;
    }
}
