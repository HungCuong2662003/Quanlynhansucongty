using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DataLayer;
using System.Collections.Generic;

namespace QLNHANSU.Reports
{
    public partial class rptBangCongCT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangCongCT()
        {
            InitializeComponent();
        }
        List<tb_BANGCONG_NHANVIEN_CHITIET> _bcct;
        public rptBangCongCT(List<tb_BANGCONG_NHANVIEN_CHITIET> bcct)
        {
            InitializeComponent();
            this._bcct = bcct;
            this.DataSource = _bcct;
            BrindData();
        }
        void BrindData()
        {
           
            lbl_manv.DataBindings.Add("Text", DataSource, "MANV");
            lbl_hoten.DataBindings.Add("Text", DataSource, "HOTEN");
            lbl_ngay.DataBindings.Add("Text", DataSource, "NGAY");
            lbl_thu.DataBindings.Add("Text", DataSource, "THU");
            lbl_giovao.DataBindings.Add("Text", DataSource, "GIOVAO");
            lbl_giora.DataBindings.Add("Text", DataSource, "GIORA");
            lbl_ngayle.DataBindings.Add("Text", DataSource, "CONGNGAYLE");
            lbl_ngayphep.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            lbl_chunhat.DataBindings.Add("Text", DataSource, "CONGCHUNHAT");
            lbl_ngaycong.DataBindings.Add("Text", DataSource, "NGAYCONG");
            lbl_kihieu.DataBindings.Add("Text", DataSource, "KYHIEU");
            lbl_ghichu.DataBindings.Add("Text", DataSource, "GHICHU");
          
        }

    }
}
