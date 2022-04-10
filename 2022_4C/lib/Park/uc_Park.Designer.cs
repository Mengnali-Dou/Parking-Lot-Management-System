namespace _2022_4C.lib.Park
{
    partial class uc_Park
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisArea = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtParkingSpot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnParkingArea = new System.Windows.Forms.Button();
            this.btnPark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1509, 843);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 30F);
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "停车场管理";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPark);
            this.panel1.Controls.Add(this.btnParkingArea);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnDisArea);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.txtParkingSpot);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPark);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 744);
            this.panel1.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 10F);
            this.btnDelete.Location = new System.Drawing.Point(201, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 54);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "删除停车场";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisArea
            // 
            this.btnDisArea.Font = new System.Drawing.Font("宋体", 10F);
            this.btnDisArea.Location = new System.Drawing.Point(19, 412);
            this.btnDisArea.Name = "btnDisArea";
            this.btnDisArea.Size = new System.Drawing.Size(136, 54);
            this.btnDisArea.TabIndex = 30;
            this.btnDisArea.Text = "停车场分区";
            this.btnDisArea.UseVisualStyleBackColor = true;
            this.btnDisArea.Click += new System.EventHandler(this.btnDisArea_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAdd.Location = new System.Drawing.Point(201, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 54);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "添加停车场";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSelect.Location = new System.Drawing.Point(19, 325);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 54);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtParkingSpot
            // 
            this.txtParkingSpot.Location = new System.Drawing.Point(112, 192);
            this.txtParkingSpot.Name = "txtParkingSpot";
            this.txtParkingSpot.Size = new System.Drawing.Size(189, 25);
            this.txtParkingSpot.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "停车区：";
            // 
            // txtPark
            // 
            this.txtPark.Location = new System.Drawing.Point(112, 129);
            this.txtPark.Name = "txtPark";
            this.txtPark.Size = new System.Drawing.Size(189, 25);
            this.txtPark.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "停车场：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(366, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1509, 843);
            this.panel2.TabIndex = 8;
            // 
            // btnParkingArea
            // 
            this.btnParkingArea.Font = new System.Drawing.Font("宋体", 10F);
            this.btnParkingArea.Location = new System.Drawing.Point(70, 503);
            this.btnParkingArea.Name = "btnParkingArea";
            this.btnParkingArea.Size = new System.Drawing.Size(231, 54);
            this.btnParkingArea.TabIndex = 22;
            this.btnParkingArea.Text = "停车区日志";
            this.btnParkingArea.UseVisualStyleBackColor = true;
            this.btnParkingArea.Click += new System.EventHandler(this.btnParkingArea_Click);
            // 
            // btnPark
            // 
            this.btnPark.Font = new System.Drawing.Font("宋体", 10F);
            this.btnPark.Location = new System.Drawing.Point(70, 594);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(231, 54);
            this.btnPark.TabIndex = 32;
            this.btnPark.Text = "停车场日志";
            this.btnPark.UseVisualStyleBackColor = true;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // uc_Park
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "uc_Park";
            this.Size = new System.Drawing.Size(1878, 872);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtParkingSpot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisArea;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnParkingArea;
        private System.Windows.Forms.Button btnPark;
    }
}
