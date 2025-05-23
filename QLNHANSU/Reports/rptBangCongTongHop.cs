﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DataLayer;
using BusinessLayer;
using System.Collections.Generic;
namespace QLNHANSU.Reports
{
    public partial class rptBangCongTongHop : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangCongTongHop()
        {
            InitializeComponent();
        }
        public rptBangCongTongHop(List<tb_KYCONGCHITIET> lstKCCT, string makycong)
        {
            InitializeComponent();
            this._lstKCCT = lstKCCT;
            this._title = makycong;
            this.DataSource = _lstKCCT;
            BindData();
        }
        public string _title="";
        List<tb_KYCONGCHITIET> _lstKCCT;
        
        public void BindData()
        {
            if (_title == "")
            {
                lblTile.Text = "BẢNG CÔNG TỔNG HỢP";
            }
            else
            {
                lblTile.Text = "BẢNG CÔNG TỔNG HỢP THÁNG  " + _title.Substring(4) + "NĂM " + _title.Substring(0, 4);
            }
            
            MANV.DataBindings.Add("Text", DataSource, "MANV");
            HOTEN.DataBindings.Add("Text", DataSource, "HOTEN");
            D1.DataBindings.Add("Text", DataSource, "D1");
            D2.DataBindings.Add("Text", DataSource, "D2");
            D3.DataBindings.Add("Text", DataSource, "D3");
            D4.DataBindings.Add("Text", DataSource, "D4");
            D5.DataBindings.Add("Text", DataSource, "D5");
            D6.DataBindings.Add("Text", DataSource, "D6");
            D7.DataBindings.Add("Text", DataSource, "D7");
            D8.DataBindings.Add("Text", DataSource, "D8");
            D9.DataBindings.Add("Text", DataSource, "D9");
            D10.DataBindings.Add("Text", DataSource, "D10");
            D11.DataBindings.Add("Text", DataSource, "D11");
            D12.DataBindings.Add("Text", DataSource, "D12");
            D13.DataBindings.Add("Text", DataSource, "D13");
            D14.DataBindings.Add("Text", DataSource, "D14");
            D15.DataBindings.Add("Text", DataSource, "D15");
            D16.DataBindings.Add("Text", DataSource, "D16");
            D17.DataBindings.Add("Text", DataSource, "D17");
            D18.DataBindings.Add("Text", DataSource, "D18");
            D19.DataBindings.Add("Text", DataSource, "D19");
            D20.DataBindings.Add("Text", DataSource, "D20");
            D21.DataBindings.Add("Text", DataSource, "D21");
            D22.DataBindings.Add("Text", DataSource, "D22");
            D23.DataBindings.Add("Text", DataSource, "D23");
            D24.DataBindings.Add("Text", DataSource, "D24");
            D25.DataBindings.Add("Text", DataSource, "D25");
            D26.DataBindings.Add("Text", DataSource, "D26");
            D27.DataBindings.Add("Text", DataSource, "D27");
            D28.DataBindings.Add("Text", DataSource, "D28");
            D29.DataBindings.Add("Text", DataSource, "D29");
            D30.DataBindings.Add("Text", DataSource, "D30");
            D31.DataBindings.Add("Text", DataSource, "D31");
            NGAYCONG.DataBindings.Add("Text", DataSource, "NGAYCONG");
      
            PHEP.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            VANG.DataBindings.Add("Text", DataSource, "NGHIKHONGPHEP");          
            LE.DataBindings.Add("Text", DataSource, "CONGNGAYLE");
            CN.DataBindings.Add("Text", DataSource, "CONGCHUNHAT");
            TONG.DataBindings.Add("Text", DataSource, "TONGNGAYCONG");
        }
    }
}
