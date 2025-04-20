namespace QLNHANSU
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCongTy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoPhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnKyLuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTangCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUngLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBangCongCT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.btnCongTy,
            this.btnPhongBan,
            this.btnBoPhan,
            this.btnNhanVien,
            this.btnChucVu,
            this.btnHopDong,
            this.btnKhenThuong,
            this.btnKyLuat,
            this.btnLoaiCa,
            this.btnLoaiCong,
            this.btnPhuCap,
            this.btnTangCa,
            this.btnUngLuong,
            this.btnBangCong,
            this.btnBangLuong,
            this.btnThoat,
            this.BtnBangCongCT,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 27;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1111, 158);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân Tộc";
            this.btnDanToc.Id = 1;
            this.btnDanToc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanToc.ImageOptions.SvgImage")));
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanToc_ItemClick);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn Giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTonGiao.ImageOptions.SvgImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonGiao_ItemClick);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình Độ";
            this.btnTrinhDo.Id = 3;
            this.btnTrinhDo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrinhDo.ImageOptions.SvgImage")));
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrinhDo_ItemClick);
            // 
            // btnCongTy
            // 
            this.btnCongTy.Caption = "Công Ty";
            this.btnCongTy.Id = 4;
            this.btnCongTy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCongTy.ImageOptions.SvgImage")));
            this.btnCongTy.Name = "btnCongTy";
            this.btnCongTy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCongTy_ItemClick);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng Ban";
            this.btnPhongBan.Id = 5;
            this.btnPhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhongBan.ImageOptions.SvgImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Caption = "Bộ Phận";
            this.btnBoPhan.Id = 6;
            this.btnBoPhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBoPhan.ImageOptions.SvgImage")));
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoPhan_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 7;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức Vụ";
            this.btnChucVu.Id = 8;
            this.btnChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChucVu.ImageOptions.SvgImage")));
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Caption = "Hợp Đồng Lao Động";
            this.btnHopDong.Id = 9;
            this.btnHopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHopDong.ImageOptions.SvgImage")));
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHopDong_ItemClick);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Caption = "Khen Thưởng";
            this.btnKhenThuong.Id = 11;
            this.btnKhenThuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhenThuong.ImageOptions.SvgImage")));
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenThuong_ItemClick);
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.Caption = "Kỷ Luật";
            this.btnKyLuat.Id = 12;
            this.btnKyLuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKyLuat.ImageOptions.SvgImage")));
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKyLuat_ItemClick);
            // 
            // btnLoaiCa
            // 
            this.btnLoaiCa.Caption = "Loại Ca";
            this.btnLoaiCa.Id = 15;
            this.btnLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCa.ImageOptions.SvgImage")));
            this.btnLoaiCa.Name = "btnLoaiCa";
            this.btnLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiCa_ItemClick);
            // 
            // btnLoaiCong
            // 
            this.btnLoaiCong.Caption = "Loại Công";
            this.btnLoaiCong.Id = 16;
            this.btnLoaiCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCong.ImageOptions.SvgImage")));
            this.btnLoaiCong.Name = "btnLoaiCong";
            this.btnLoaiCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiCong_ItemClick);
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.Caption = "Phụ Cấp";
            this.btnPhuCap.Id = 17;
            this.btnPhuCap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhuCap.ImageOptions.SvgImage")));
            this.btnPhuCap.Name = "btnPhuCap";
            this.btnPhuCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuCap_ItemClick);
            // 
            // btnTangCa
            // 
            this.btnTangCa.Caption = "Tăng Ca";
            this.btnTangCa.Id = 18;
            this.btnTangCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTangCa.ImageOptions.SvgImage")));
            this.btnTangCa.Name = "btnTangCa";
            this.btnTangCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTangCa_ItemClick);
            // 
            // btnUngLuong
            // 
            this.btnUngLuong.Caption = "Ứng Lương";
            this.btnUngLuong.Id = 19;
            this.btnUngLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUngLuong.ImageOptions.SvgImage")));
            this.btnUngLuong.Name = "btnUngLuong";
            this.btnUngLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUngLuong_ItemClick);
            // 
            // btnBangCong
            // 
            this.btnBangCong.Caption = "Bảng Công";
            this.btnBangCong.Id = 20;
            this.btnBangCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangCong.ImageOptions.SvgImage")));
            this.btnBangCong.Name = "btnBangCong";
            this.btnBangCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangCong_ItemClick);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Caption = "Bảng Lương";
            this.btnBangLuong.Id = 21;
            this.btnBangLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangLuong.ImageOptions.SvgImage")));
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangLuong_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 22;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // BtnBangCongCT
            // 
            this.BtnBangCongCT.Caption = "Bảng công chi tiết";
            this.BtnBangCongCT.Id = 24;
            this.BtnBangCongCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBangCongCT.ImageOptions.LargeImage")));
            this.BtnBangCongCT.Name = "BtnBangCongCT";
            this.BtnBangCongCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBangCongCT_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Phụ cấp";
            this.barButtonItem1.Id = 26;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nhân Sự";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanToc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonGiao, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrinhDo, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCongTy, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongBan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBoPhan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChucVu, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh Mục Dùng Chung";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHopDong);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhenThuong, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKyLuat, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nghiệp Vụ";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Chấm Công";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaiCa);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaiCong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhuCap, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTangCa, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUngLuong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangCong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnBangCongCT, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangLuong);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản Lý Chấm Công";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 488);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Phần Mềm Quản Lý Nhân Sự - Chấm Công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.BarButtonItem btnCongTy;
        private DevExpress.XtraBars.BarButtonItem btnPhongBan;
        private DevExpress.XtraBars.BarButtonItem btnBoPhan;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.BarButtonItem btnHopDong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnKhenThuong;
        private DevExpress.XtraBars.BarButtonItem btnKyLuat;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCong;
        private DevExpress.XtraBars.BarButtonItem btnPhuCap;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnTangCa;
        private DevExpress.XtraBars.BarButtonItem btnUngLuong;
        private DevExpress.XtraBars.BarButtonItem btnBangCong;
        private DevExpress.XtraBars.BarButtonItem btnBangLuong;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem BtnBangCongCT;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

