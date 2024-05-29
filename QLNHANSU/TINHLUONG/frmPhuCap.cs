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
    public partial class frmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCap()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        PHUCAP _phucap;
        bool _them;
        int _id;
        private void frmPhuCap_Load(object sender, EventArgs e)
        {
            _them = false;
            _phucap = new PHUCAP();
            _nhanvien = new NHANVIEN();
            _showHide(true);
            loadData();
            loadNhanVien();
            loadPhuCap();
            cbPhuCap.SelectedIndexChanged += cbPhuCap_SelectedIndexChanged;
        }

        private void cbPhuCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pc = _phucap.getItemPC(int.Parse(cbPhuCap.SelectedIndex.ToString()));
            if (pc != null)
            {
                speSOTIEN.EditValue = pc.SOTIEN;
            }
        }

        void loadPhuCap()
        {
            cbPhuCap.DataSource = _phucap.getListPC();
            cbPhuCap.DisplayMember = "TENPC";
            cbPhuCap.ValueMember = "IDPC";
        }
        void loadNhanVien()
        {
            sNV.Properties.DataSource = _nhanvien.getListFull();
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
            txtNOIDUNG.Enabled = !kt;
            speSOTIEN.Enabled = !kt;
            sNV.Enabled = !kt;
            cbPhuCap.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _phucap.getListFull();
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
                _phucap.Delete(_id);
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
                tb_NHANVIEN_PHUCAP pc = new tb_NHANVIEN_PHUCAP();
                pc.IDPC = int.Parse(cbPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(speSOTIEN.EditValue.ToString());
                pc.MANV = int.Parse(sNV.EditValue.ToString());
                pc.NOIDUNG = txtNOIDUNG.Text;
                pc.NGAY = DateTime.Now;
                _phucap.Add(pc);
            }
            else
            {
                var pc = _phucap.getItem(_id);
                pc.IDPC = int.Parse(cbPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(speSOTIEN.EditValue.ToString());
                pc.MANV = int.Parse(sNV.EditValue.ToString());
                pc.NOIDUNG = txtNOIDUNG.Text;
                pc.NGAY = DateTime.Now;
                _phucap.Update(pc);
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
               txtNOIDUNG.Text = gvDanhSach.GetFocusedRowCellValue("NOIDUNG").ToString();
                speSOTIEN.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN").ToString();
                sNV.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV").ToString();
                cbPhuCap.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDPC").ToString();
            }
        }
    }
}