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
    public partial class frmKyLuat : DevExpress.XtraEditors.XtraForm
    {
        public frmKyLuat()
        {
            InitializeComponent();
        }
        KYLUAT _kyluat;
        NHANVIEN _nhanvien;
        bool _them;
        string _sqd;
        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            _them = false;
            _kyluat = new KYLUAT();
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
        void _showHide(bool kl)
        {
            btnLuu.Enabled = !kl;
            btnHuy.Enabled = !kl;
            btnThem.Enabled = kl;
            btnSua.Enabled = kl;
            btnXoa.Enabled = kl;
            btnDong.Enabled = kl;
            btnIn.Enabled = kl;
            txtSOQD.Enabled = !kl;
            dtpNGAYKL.Enabled = !kl;
            dtpDENNGAY.Enabled = !kl;
            txtLYDO.Enabled = !kl;
            txtNOIDUNG.Enabled = !kl;
            sNV.Enabled = !kl;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _kyluat.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                _kyluat.Delete(_sqd);
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
                var maxSOQD = _kyluat.MaxSoQuyetDinh();
                int so = int.Parse(maxSOQD.Substring(0, 5)) + 1;
                tb_KYLUAT kl = new tb_KYLUAT();
                kl.SOQUYETDINH = so.ToString("00000") + @"/2023/QĐKL";
                kl.TUNGAY = dtpNGAYKL.Value;
                kl.DENNGAY = dtpDENNGAY.Value;
                kl.MANV = int.Parse(sNV.EditValue.ToString());
                kl.LYDO = txtLYDO.Text;
                kl.NOIDUNG = txtNOIDUNG.Text;
                _kyluat.Add(kl);
            }
            else
            {
                var kl = _kyluat.getItem(_sqd);
                kl.TUNGAY = dtpNGAYKL.Value;
                kl.DENNGAY = dtpDENNGAY.Value;
                kl.MANV = int.Parse(sNV.EditValue.ToString());
                kl.LYDO = txtLYDO.Text;
                kl.NOIDUNG = txtNOIDUNG.Text;
                _kyluat.Update(kl);
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
                var kl = _kyluat.getItem(_sqd);
                txtSOQD.Text = _sqd;
                dtpNGAYKL.Value = kl.TUNGAY.Value;
                dtpDENNGAY.Value = kl.DENNGAY.Value;
                txtLYDO.Text = kl.LYDO;
                txtNOIDUNG.Text = kl.NOIDUNG;
                sNV.EditValue = kl.MANV;
            }
        }
    }
}