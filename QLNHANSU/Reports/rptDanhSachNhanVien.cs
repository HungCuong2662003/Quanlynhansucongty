using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNHANSU.Reports
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<NHANVIEN_DTO> _lstNV;
        public rptDanhSachNhanVien(List<NHANVIEN_DTO> lstNV)
        {
            InitializeComponent();
            this._lstNV = lstNV;
            this.DataSource = _lstNV;
            loadData();
        }
        void loadData()
        {
            lbMANV.DataBindings.Add("Text", _lstNV, "MANV");
            lbHOTEN.DataBindings.Add("Text", _lstNV, "HOTEN");
            lbGIOITINH.DataBindings.Add("Text", _lstNV, "GIOITINH");
            lbNGAYSINH.DataBindings.Add("Text", _lstNV, "NGAYSINH");
            lbCHUCVU.DataBindings.Add("Text", _lstNV, "TENCV");
            lbBOPHAN.DataBindings.Add("Text", _lstNV, "TENBP");
            lbPHONGBAN.DataBindings.Add("Text", _lstNV, "TENPB");
            lbTRINHDO.DataBindings.Add("Text", _lstNV, "TENTD");
            lbDANTOC.DataBindings.Add("Text", _lstNV, "TENDT");
            lbTONGIAO.DataBindings.Add("Text", _lstNV, "TENTG");
            lbCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            lbDIACHI.DataBindings.Add("Text", _lstNV, "DIACHI");
            lbSDT.DataBindings.Add("Text", _lstNV, "DIENTHOAI");
        }
    }
}
