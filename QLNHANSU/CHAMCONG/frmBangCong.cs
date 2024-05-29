using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU.CHAMCONG
{
    public partial class frmBangCong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCong()
        {
            InitializeComponent();
        }
        KYCONG _kycong;
        bool _them;
        int _makycong;
        private void frmBangCong_Load(object sender, EventArgs e)
        {
            _them = false;
            _kycong = new KYCONG();
            _showHide(true);
            loadData();
            cbNam.Text = DateTime.Now.Year.ToString();
            cbThang.Text = DateTime.Now.Month.ToString();
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            cbNam.Enabled = !kt;
            cbThang.Enabled = !kt;
            ckbKhoa.Enabled = !kt;
            ckbTrangThai.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _kycong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            cbThang.Text = DateTime.Now.ToString();
            cbNam.Text = DateTime.Now.ToString();
           
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _kycong.Delete(_makycong);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveDate();
            loadData();
            _showHide(true);
            _them = false;
        }
        void SaveDate()
        {
            if (_them)
            {
                tb_KYCONG kc = new tb_KYCONG();
                kc.MAKYCONG = int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text);
                kc.NAM = int.Parse(cbNam.Text);
                kc.THANG = int.Parse(cbThang.Text);
                kc.KHOA = ckbKhoa.Checked;
                kc.TRANGTHAI = ckbKhoa.Checked;
                kc.MACTY = 1;
                kc.NGAYCONGTRONGTHANG = Cuong_Functions.demSoNgayLamViecTrongThang(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                _kycong.Add(kc);
            }
            else
            {
                var kc = _kycong.getItem(_makycong);
                kc.NAM = int.Parse(cbNam.Text);
                kc.THANG = int.Parse(cbThang.Text);
                kc.KHOA = ckbKhoa.Checked;
                kc.TRANGTHAI = ckbKhoa.Checked;
                kc.NGAYCONGTRONGTHANG = Cuong_Functions.demSoNgayLamViecTrongThang(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                _kycong.Update(kc);
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _makycong = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAKYCONG").ToString());
                cbNam.Text = gvDanhSach.GetFocusedRowCellValue("NAM").ToString();
                cbThang.Text = gvDanhSach.GetFocusedRowCellValue("THANG").ToString();
                ckbKhoa.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("KHOA").ToString());
                ckbTrangThai.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
            }
        }

        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangCongChiTiet frm = new frmBangCongChiTiet();
            frm._makycong = _makycong;
            frm._thang = int.Parse(cbThang.Text);
            frm._nam = int.Parse(cbNam.Text);
            frm._macty = 1;
            frm.ShowDialog();
        }
    }
}