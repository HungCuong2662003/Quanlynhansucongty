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

namespace QLNHANSU.TINHLUONG
{
    public partial class frmUngLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmUngLuong()
        {
            InitializeComponent();
        }
        UNGLUONG _ul;
        NHANVIEN _nhanvien;
        bool _them;
        int _id;
        private void frmUngLuong_Load(object sender, EventArgs e)
        {
            _ul = new UNGLUONG();
            _nhanvien = new NHANVIEN();
            _them = false;
            _showHide(true);
            loadData();
            loadNhanVien();
        }
        void loadNhanVien()
        {
            sNV.Properties.DataSource = _nhanvien.getListFull();
            sNV.Properties.ValueMember = "MANV";
            sNV.Properties.DisplayMember = "HOTEN";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _ul.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
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
            txtNOIDUNG.Enabled = !kt;
            speSOTIEN.Enabled = !kt;
            sNV.Enabled = !kt;
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
                _ul.Delete(_id);
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

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }
        void SaveDate()
        {
            if (_them)
            {
                tb_UNGLUONG ul = new tb_UNGLUONG();
                ul.SOTIEN = double.Parse(speSOTIEN.EditValue.ToString());
                ul.MANV = int.Parse(sNV.EditValue.ToString());
                ul.GHICHU = txtNOIDUNG.Text;
                ul.NGAY = DateTime.Now.Day;
               // ul.THANG = DateTime.Now.Month-1;
                ul.THANG = DateTime.Now.Month ;
                ul.NAM = DateTime.Now.Year;
               // ul.NGAYMACDINH = DateTime.Now.AddMonths(-1);
                ul.NGAYMACDINH = DateTime.Now;
                _ul.Add(ul);
            }
            else
            {
                var ul = _ul.getItem(_id);
                ul.SOTIEN = double.Parse(speSOTIEN.EditValue.ToString());
                ul.MANV = int.Parse(sNV.EditValue.ToString());
                ul.GHICHU = txtNOIDUNG.Text;
                ul.NGAY = DateTime.Now.Day;
               // ul.THANG = DateTime.Now.Month - 1;
                ul.THANG = DateTime.Now.Month;
                ul.NAM = DateTime.Now.Year;
                //ul.NGAYMACDINH = DateTime.Now.AddMonths(-1);
                ul.NGAYMACDINH = DateTime.Now;
                _ul.Update(ul);
            }
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
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtNOIDUNG.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                speSOTIEN.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN").ToString();
                sNV.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV").ToString();
            }
        }
    }
}