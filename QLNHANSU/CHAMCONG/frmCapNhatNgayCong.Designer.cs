namespace QLNHANSU.CHAMCONG
{
    partial class frmCapNhatNgayCong
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cldNgayCong = new System.Windows.Forms.MonthCalendar();
            this.groupChamCong = new DevExpress.XtraEditors.GroupControl();
            this.rdgChamCong = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdgThoiGianNghi = new DevExpress.XtraEditors.RadioGroup();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.blHOTEN = new System.Windows.Forms.Label();
            this.blID = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Label();
            this.bl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupChamCong)).BeginInit();
            this.groupChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgThoiGianNghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(263, 284);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 39);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cldNgayCong
            // 
            this.cldNgayCong.Location = new System.Drawing.Point(15, 15);
            this.cldNgayCong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cldNgayCong.Name = "cldNgayCong";
            this.cldNgayCong.TabIndex = 1;
            this.cldNgayCong.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldNgayCong_DateSelected);
            // 
            // groupChamCong
            // 
            this.groupChamCong.Controls.Add(this.rdgChamCong);
            this.groupChamCong.Location = new System.Drawing.Point(226, 15);
            this.groupChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupChamCong.Name = "groupChamCong";
            this.groupChamCong.Size = new System.Drawing.Size(281, 115);
            this.groupChamCong.TabIndex = 2;
            this.groupChamCong.Text = "Chấm Công";
            // 
            // rdgChamCong
            // 
            this.rdgChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgChamCong.Location = new System.Drawing.Point(2, 23);
            this.rdgChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdgChamCong.Name = "rdgChamCong";
            this.rdgChamCong.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ Phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Vắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CNL", "Công Ngày Lễ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CNCN", "Công Ngày Chủ Nhật"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("X", "Đi làm ")});
            this.rdgChamCong.Size = new System.Drawing.Size(277, 90);
            this.rdgChamCong.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdgThoiGianNghi);
            this.groupControl1.Location = new System.Drawing.Point(228, 134);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(278, 131);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thời Gian Nghỉ";
            // 
            // rdgThoiGianNghi
            // 
            this.rdgThoiGianNghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgThoiGianNghi.Location = new System.Drawing.Point(2, 23);
            this.rdgThoiGianNghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdgThoiGianNghi.Name = "rdgThoiGianNghi";
            this.rdgThoiGianNghi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NN", "Nguyên Ngày")});
            this.rdgThoiGianNghi.Size = new System.Drawing.Size(274, 106);
            this.rdgThoiGianNghi.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(368, 284);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 39);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.blHOTEN);
            this.groupControl2.Controls.Add(this.blID);
            this.groupControl2.Controls.Add(this.b2);
            this.groupControl2.Controls.Add(this.bl1);
            this.groupControl2.Location = new System.Drawing.Point(15, 193);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(177, 115);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Thông Tin ";
            // 
            // blHOTEN
            // 
            this.blHOTEN.AutoSize = true;
            this.blHOTEN.Location = new System.Drawing.Point(51, 68);
            this.blHOTEN.Name = "blHOTEN";
            this.blHOTEN.Size = new System.Drawing.Size(51, 13);
            this.blHOTEN.TabIndex = 3;
            this.blHOTEN.Text = "HỌ TÊN: ";
            // 
            // blID
            // 
            this.blID.AutoSize = true;
            this.blID.Location = new System.Drawing.Point(22, 33);
            this.blID.Name = "blID";
            this.blID.Size = new System.Drawing.Size(22, 13);
            this.blID.TabIndex = 2;
            this.blID.Text = "ID:";
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Location = new System.Drawing.Point(5, 68);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(51, 13);
            this.b2.TabIndex = 1;
            this.b2.Text = "HỌ TÊN: ";
            // 
            // bl1
            // 
            this.bl1.AutoSize = true;
            this.bl1.Location = new System.Drawing.Point(5, 33);
            this.bl1.Name = "bl1";
            this.bl1.Size = new System.Drawing.Size(22, 13);
            this.bl1.TabIndex = 0;
            this.bl1.Text = "ID:";
            // 
            // frmCapNhatNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 372);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupChamCong);
            this.Controls.Add(this.cldNgayCong);
            this.Controls.Add(this.btnCapNhat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatNgayCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Ngày Công";
            this.Load += new System.EventHandler(this.frmCapNhatNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupChamCong)).EndInit();
            this.groupChamCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgThoiGianNghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.MonthCalendar cldNgayCong;
        private DevExpress.XtraEditors.GroupControl groupChamCong;
        private DevExpress.XtraEditors.RadioGroup rdgChamCong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rdgThoiGianNghi;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label blHOTEN;
        private System.Windows.Forms.Label blID;
        private System.Windows.Forms.Label b2;
        private System.Windows.Forms.Label bl1;
    }
}