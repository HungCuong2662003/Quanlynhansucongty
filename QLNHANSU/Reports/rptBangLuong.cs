using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DataLayer;
using System.Collections.Generic;
namespace QLNHANSU.Reports
{
    public partial class rptBangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangLuong()
        {
            InitializeComponent();
        }
        List<tb_BANGLUONG> _lst;
        int _namky;
        public rptBangLuong(List<tb_BANGLUONG> lst, int namky)
        {
            InitializeComponent();
            this._lst = lst; 
            this._namky = namky;
            this.DataSource = _lst;
            lbl_thangnam.Text= "Tháng "+ _namky.ToString().Substring(4) + " Năm " + _namky.ToString().Substring(0,4);    
            LoadData();
        }
        void LoadData()
        {
            manv.DataBindings.Add("Text", DataSource, "MANV");
            hoten.DataBindings.Add("Text", DataSource, "HOTEN");
            ngaycong.DataBindings.Add("Text", DataSource, "NGAYCONGTRONGTHANG");
            ngayphep.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            ngayle.DataBindings.Add("Text", DataSource, "NGAYLE");
            luongcn.DataBindings.Add("Text", DataSource, "NGAYCHUNHAT");
            tangca.DataBindings.Add("Text", DataSource, "TANGCA");
            phucap.DataBindings.Add("Text", DataSource, "PHUCAP");
            ungluong.DataBindings.Add("Text", DataSource, "UNGLUONG");
            luongngaythuong.DataBindings.Add("Text", DataSource, "NGAYTHUONG");
            thuclanh.DataBindings.Add("Text", DataSource, "THUCLANH");
        }
    }
}
