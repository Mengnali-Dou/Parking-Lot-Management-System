namespace _2022_4C.lib.Blacklist
{
    partial class uc_Blacklist
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtLicensePlateNum = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpreatorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBOwner = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnBVehicle = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 30F);
            this.label1.Location = new System.Drawing.Point(60, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "违规处理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "车牌号：";
            // 
            // txtLicensePlateNum
            // 
            this.txtLicensePlateNum.Location = new System.Drawing.Point(117, 255);
            this.txtLicensePlateNum.Name = "txtLicensePlateNum";
            this.txtLicensePlateNum.Size = new System.Drawing.Size(202, 25);
            this.txtLicensePlateNum.TabIndex = 4;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(117, 304);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(202, 25);
            this.txtOwnerID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "车主姓名：";
            // 
            // txtOpreatorID
            // 
            this.txtOpreatorID.Location = new System.Drawing.Point(117, 355);
            this.txtOpreatorID.Name = "txtOpreatorID";
            this.txtOpreatorID.Size = new System.Drawing.Size(202, 25);
            this.txtOpreatorID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "操作员：";
            // 
            // btnBOwner
            // 
            this.btnBOwner.Font = new System.Drawing.Font("宋体", 10F);
            this.btnBOwner.Location = new System.Drawing.Point(209, 599);
            this.btnBOwner.Name = "btnBOwner";
            this.btnBOwner.Size = new System.Drawing.Size(136, 54);
            this.btnBOwner.TabIndex = 10;
            this.btnBOwner.Text = "车主黑名单";
            this.btnBOwner.UseVisualStyleBackColor = true;
            this.btnBOwner.Click += new System.EventHandler(this.btnBOwner_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("宋体", 10F);
            this.btnInsert.Location = new System.Drawing.Point(18, 701);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 54);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "插入数据";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 10F);
            this.btnDelete.Location = new System.Drawing.Point(209, 701);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 54);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "删除数据";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSelect.Location = new System.Drawing.Point(209, 506);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 54);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnBVehicle
            // 
            this.btnBVehicle.Font = new System.Drawing.Font("宋体", 10F);
            this.btnBVehicle.Location = new System.Drawing.Point(18, 599);
            this.btnBVehicle.Name = "btnBVehicle";
            this.btnBVehicle.Size = new System.Drawing.Size(136, 54);
            this.btnBVehicle.TabIndex = 14;
            this.btnBVehicle.Text = "车辆黑名单";
            this.btnBVehicle.UseVisualStyleBackColor = true;
            this.btnBVehicle.Click += new System.EventHandler(this.btnBVehicle_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSelectAll.Location = new System.Drawing.Point(18, 506);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(136, 54);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "违规车辆";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // uc_Blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnBVehicle);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBOwner);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.txtOpreatorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLicensePlateNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "uc_Blacklist";
            this.Size = new System.Drawing.Size(1878, 872);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLicensePlateNum;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpreatorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBOwner;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBVehicle;
        private System.Windows.Forms.Button btnSelectAll;
    }
}
