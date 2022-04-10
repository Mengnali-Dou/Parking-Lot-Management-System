
namespace _2022_4C.lib.Rent
{
    partial class form_RentOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RentOut));
            this.label1 = new System.Windows.Forms.Label();
            this.txtParkingSpot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labID = new System.Windows.Forms.Label();
            this.txtPark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combBeginTime = new System.Windows.Forms.ComboBox();
            this.combEndTime = new System.Windows.Forms.ComboBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "停车位：";
            // 
            // txtParkingSpot
            // 
            this.txtParkingSpot.Location = new System.Drawing.Point(160, 152);
            this.txtParkingSpot.Name = "txtParkingSpot";
            this.txtParkingSpot.Size = new System.Drawing.Size(167, 27);
            this.txtParkingSpot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "开始时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "结束时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "车牌号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(157, 46);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(26, 17);
            this.labID.TabIndex = 6;
            this.labID.Text = "--";
            // 
            // txtPark
            // 
            this.txtPark.Location = new System.Drawing.Point(160, 98);
            this.txtPark.Name = "txtPark";
            this.txtPark.Size = new System.Drawing.Size(167, 27);
            this.txtPark.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "停车场：";
            // 
            // combBeginTime
            // 
            this.combBeginTime.FormattingEnabled = true;
            this.combBeginTime.Items.AddRange(new object[] {
            "01:00",
            "02:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.combBeginTime.Location = new System.Drawing.Point(160, 213);
            this.combBeginTime.Name = "combBeginTime";
            this.combBeginTime.Size = new System.Drawing.Size(167, 25);
            this.combBeginTime.TabIndex = 9;
            this.combBeginTime.Text = "08:00";
            // 
            // combEndTime
            // 
            this.combEndTime.FormattingEnabled = true;
            this.combEndTime.Items.AddRange(new object[] {
            "01:00",
            "02:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.combEndTime.Location = new System.Drawing.Point(160, 264);
            this.combEndTime.Name = "combEndTime";
            this.combEndTime.Size = new System.Drawing.Size(167, 25);
            this.combEndTime.TabIndex = 10;
            this.combEndTime.Text = "18:00";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(212, 346);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(115, 51);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "确定";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // form_RentOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 471);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.combEndTime);
            this.Controls.Add(this.combBeginTime);
            this.Controls.Add(this.txtPark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParkingSpot);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_RentOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出租信息";
            this.Load += new System.EventHandler(this.form_RentOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParkingSpot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox txtPark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combBeginTime;
        private System.Windows.Forms.ComboBox combEndTime;
        private System.Windows.Forms.Button btnFinish;
    }
}