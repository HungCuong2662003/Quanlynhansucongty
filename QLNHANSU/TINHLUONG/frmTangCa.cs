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
    public partial class frmTangCa : DevExpress.XtraEditors.XtraForm
    {
        public frmTangCa()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        TANGCA _tangca;
        LOAICA _lc;
        BANGLUONG _bangluong;
        SYS_CONFIG _config;
        bool _them;
        int _id;
        private void frmTangCa_Load(object sender, EventArgs e)
        {
            _them = false;
            _tangca = new TANGCA();
            _bangluong=new BANGLUONG();
            _nhanvien = new NHANVIEN();
            _lc = new LOAICA();
            _config = new SYS_CONFIG();
            _showHide(true);
            loadData();
            loadNhanVien();
            loadLoaiCa();
        }
        void loadLoaiCa()
        {
            cbLoaiCa.DataSource = _lc.getList();
            cbLoaiCa.DisplayMember = "TENLOAICA";
            cbLoaiCa.ValueMember = "IDLOAICA";
        }
        void loadNhanVien()
        {
            sNV.Properties.DataSource = _nhanvien.getListFull();
            sNV.Properties.ValueMember = "MANV";
            sNV.Properties.DisplayMember = "HOTEN";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _tangca.getListFull();
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
            speSOGIO.Enabled = !kt;
            sNV.Enabled = !kt;
            cbLoaiCa.Enabled = !kt;
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
                _tangca.Delete(_id);
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
            if (cbLoaiCa.SelectedValue==null)
            {
                MessageBox.Show("Hãy chọn loại tăng ca");
                return;
            }
            if (_them)
            {
                tb_TANGCA tc = new tb_TANGCA();
                tc.IDLOAICA = int.Parse(cbLoaiCa.SelectedValue.ToString());
                tc.SOGIO = double.Parse(speSOGIO.EditValue.ToString());
                tc.MANV = int.Parse(sNV.EditValue.ToString());
                tc.GHICHU = txtNOIDUNG.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                var lc = _lc.getItem(int.Parse(cbLoaiCa.SelectedValue.ToString()));
               
                //MessageBox.Show(_bangluong.luong1ngaycong(DateTime.Now.Year * 100 + DateTime.Now.Month, int.Parse(sNV.EditValue.ToString())).ToString());

                float luong1gio = (_bangluong.luong1ngaycong(DateTime.Now.Year * 100 + DateTime.Now.Month, int.Parse(sNV.EditValue.ToString()))) / 8;
                tc.SOTIEN = tc.SOGIO * lc.HESO * luong1gio;
                _tangca.Add(tc);
            }
            else
            {
                var tc = _tangca.getItem(_id);
                tc.IDLOAICA = int.Parse(cbLoaiCa.SelectedValue.ToString());
                tc.SOGIO = double.Parse(speSOGIO.EditValue.ToString());
                tc.MANV = int.Parse(sNV.EditValue.ToString());
                tc.GHICHU = txtNOIDUNG.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                var lc = _lc.getItem(int.Parse(cbLoaiCa.SelectedValue.ToString()));
                //var cg = _config.getItem("TANGCA");
                //tc.SOTIEN = tc.SOGIO * lc.HESO * int.Parse(cg.Value);
                float luong1gio = (_bangluong.luong1ngaycong(DateTime.Now.Year * 100 + DateTime.Now.Month, int.Parse(sNV.EditValue.ToString())))/8;
                tc.SOTIEN = tc.SOGIO * lc.HESO * luong1gio;
                _tangca.Update(tc);
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
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtNOIDUNG.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                speSOGIO.EditValue = gvDanhSach.GetFocusedRowCellValue("SOGIO").ToString();
                sNV.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV").ToString();
                cbLoaiCa.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDLOAICA").ToString();
            }
        }
    }
}