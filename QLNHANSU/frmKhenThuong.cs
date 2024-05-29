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

namespace QLNHANSU
{
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }
        KHENTHUONG _khenthuong;
        NHANVIEN _nhanvien;
        bool _them;
        string _sqd;
        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            _them = false;
            _khenthuong = new KHENTHUONG();
            _nhanvien = new NHANVIEN();
            loadNhanVien();
            _showHide(true);
            loadData();
        }
        void loadNhanVien()
        {
            sNV.Properties.DataSource = _nhanvien.getList();
            sNV.Properties.ValueMember = "MANV";
            sNV.Properties.DisplayMember = "HOTEN";
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
            txtSOQD.Enabled = !kt;
            dtpNGAYKT.Enabled = !kt;
            txtLYDO.Enabled = !kt;
            txtNOIDUNG.Enabled = !kt;
            sNV.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _khenthuong.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
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
                _khenthuong.Delete(_sqd);
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
                var maxSOQD = _khenthuong.MaxSoQuyetDinh();
                int so = int.Parse(maxSOQD.Substring(0, 5)) + 1;
                tb_KHENTHUONG kt = new tb_KHENTHUONG();
                kt.SOQUYETDINH = so.ToString("00000") + @"/2024/QĐKT";
                kt.NGAY = dtpNGAYKT.Value;
                kt.MANV = int.Parse(sNV.EditValue.ToString());
                kt.LYDO = txtLYDO.Text;
                kt.NOIDUNG = txtNOIDUNG.Text;
                _khenthuong.Add(kt);
            }
            else
            {
                var kt = _khenthuong.getItem(_sqd);
                kt.NGAY = dtpNGAYKT.Value;
                kt.MANV = int.Parse(sNV.EditValue.ToString());
                kt.LYDO = txtLYDO.Text;
                kt.NOIDUNG = txtNOIDUNG.Text;
                _khenthuong.Update(kt);
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
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
            if (gvDanhSach.RowCount > 0)
            {
                _sqd = gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var kt = _khenthuong.getItem(_sqd);
                txtSOQD.Text = _sqd;
                dtpNGAYKT.Value = kt.NGAY.Value;
                txtLYDO.Text = kt.LYDO;
                txtNOIDUNG.Text = kt.NOIDUNG;                
                sNV.EditValue = kt.MANV;
            }
        }
    }
}