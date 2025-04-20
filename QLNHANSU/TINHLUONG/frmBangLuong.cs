using BusinessLayer;
using DevExpress.XtraEditors;
using QLNHANSU.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DataLayer;

namespace QLNHANSU.TINHLUONG
{
    public partial class frmBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }
        tb_LOGIN tb_LOGIN = new tb_LOGIN();
        BANGLUONG _bangluong;
        List<tb_BANGLUONG> _listBangLuong;
        KYCONGCHITIET _kcct;
        int _namky;
        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            _bangluong = new BANGLUONG(); 
            _kcct = new KYCONGCHITIET();
            cbNam.Text = DateTime.Now.Year.ToString();
            cbThang.Text = DateTime.Now.Month.ToString();
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_kcct.getList(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text)).Any())
            {
                MessageBox.Show("Bạn chưa chốt công tháng này");
                return;
            }
            _bangluong.TinhLuongNhanVien(int.Parse(cbNam.Text)*100+int.Parse(cbThang.Text));
            loadData();

        }
        void loadData()
        {
           gcDanhSach.DataSource = _bangluong.getList(int.Parse(cbNam.Text) *100+ int.Parse(cbThang.Text));
           gvDanhSach.OptionsBehavior.Editable = false;
            _listBangLuong = _bangluong.getList(int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text));
            _namky = int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text);
        }
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptBangLuong rptBangLuong = new rptBangLuong(_listBangLuong,_namky);
            rptBangLuong.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}