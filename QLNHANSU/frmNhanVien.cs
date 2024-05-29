using BusinessLayer.DTO;
using BusinessLayer;
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
using DataLayer;
using QLNHANSU.Reports;
using DevExpress.XtraReports.UI;

namespace QLNHANSU
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        DANTOC _dantoc;
        TONGIAO _tongiao;
        CHUCVU _chucvu;
        TRINHDO _trinhdo;
        PHONGBAN _phongban;
        BOPHAN _bophan;
        bool _them;
        int _id;
        List<NHANVIEN_DTO> _lstNVDTO;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new NHANVIEN();
            _dantoc = new DANTOC();
            _tongiao = new TONGIAO();
            _chucvu = new CHUCVU();
            _trinhdo = new TRINHDO();
            _phongban = new PHONGBAN();
            _bophan = new BOPHAN();
            loadCombo();
            _showHide(true);
            loadData();
        }
        void loadCombo()
        {
            cbbBP.DataSource = _bophan.getList();
            cbbBP.DisplayMember = "TENBP";
            cbbBP.ValueMember = "IDBP";

            cbbPB.DataSource = _phongban.getList();
            cbbPB.DisplayMember = "TENPB";
            cbbPB.ValueMember = "IDPB";

            cbbTD.DataSource = _trinhdo.getList();
            cbbTD.DisplayMember = "TENTD";
            cbbTD.ValueMember = "IDTD";

            cbbCV.DataSource = _chucvu.getList();
            cbbCV.DisplayMember = "TENCV";
            cbbCV.ValueMember = "IDCV";

            cbbDT.DataSource = _dantoc.getList();
            cbbDT.DisplayMember = "TENDT";
            cbbDT.ValueMember = "IDDT";

            cbbTG.DataSource = _tongiao.getList();
            cbbTG.DisplayMember = "TENTG";
            cbbTG.ValueMember = "IDTG";
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
            txtHOTEN.Enabled = !kt;
            cbbBP.Enabled = !kt;
            cbbCV.Enabled = !kt;
            cbbDT.Enabled = !kt;
            cbbPB.Enabled = !kt;
            cbbTD.Enabled = !kt;
            cbbTG.Enabled = !kt;
            cbGIOITINH.Enabled = !kt;
            dtpNGAYSINH.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtSDT.Enabled = !kt;

        }
        void loadData()
        {
            gcDanhSach.DataSource = _nhanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstNVDTO = _nhanvien.getListFull();
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
                _nhanvien.Delete(_id);
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
                tb_NHANVIEN nv = new tb_NHANVIEN();
                nv.HOTEN = txtHOTEN.Text;
                nv.GIOITINH = cbGIOITINH.Checked;
                nv.NGAYSINH = dtpNGAYSINH.Value;
                nv.DIENTHOAI = txtSDT.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.DATHOIVIEC = null;
                nv.IDBP = int.Parse(cbbBP.SelectedValue.ToString());
                nv.IDPB = int.Parse(cbbPB.SelectedValue.ToString());
                nv.IDCV = int.Parse(cbbCV.SelectedValue.ToString());
                nv.IDTD = int.Parse(cbbTD.SelectedValue.ToString());
                nv.IDDT = int.Parse(cbbDT.SelectedValue.ToString());
                nv.IDTG = int.Parse(cbbTG.SelectedValue.ToString());
                nv.MACTY = 1;
                _nhanvien.Add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HOTEN = txtHOTEN.Text;
                nv.GIOITINH = cbGIOITINH.Checked;
                nv.NGAYSINH = dtpNGAYSINH.Value;
                nv.DIENTHOAI = txtSDT.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.DATHOIVIEC = null;
                nv.IDBP = int.Parse(cbbBP.SelectedValue.ToString());
                nv.IDPB = int.Parse(cbbPB.SelectedValue.ToString());
                nv.IDCV = int.Parse(cbbCV.SelectedValue.ToString());
                nv.IDTD = int.Parse(cbbTD.SelectedValue.ToString());
                nv.IDDT = int.Parse(cbbDT.SelectedValue.ToString());
                nv.IDTG = int.Parse(cbbTG.SelectedValue.ToString());
                nv.MACTY = 1;
                _nhanvien.Update(nv);
            }
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptDanhSachNhanVien rpt = new rptDanhSachNhanVien(_lstNVDTO);
            rpt.ShowPreview();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANV").ToString());
                var nv = _nhanvien.getItem(_id);
                txtHOTEN.Text = nv.HOTEN;
                cbGIOITINH.Checked = nv.GIOITINH.Value;
                dtpNGAYSINH.Value = nv.NGAYSINH.Value;
                txtSDT.Text = nv.DIENTHOAI;
                txtCCCD.Text = nv.CCCD;
                txtDiaChi.Text = nv.DIACHI;
                cbbBP.SelectedValue = nv.IDBP;
                cbbPB.SelectedValue = nv.IDPB;
                cbbTD.SelectedValue = nv.IDTD;
                cbbCV.SelectedValue = nv.IDCV;
                cbbDT.SelectedValue = nv.IDDT;
                cbbTG.SelectedValue = nv.IDTG;
                
            }
        }
    }
}