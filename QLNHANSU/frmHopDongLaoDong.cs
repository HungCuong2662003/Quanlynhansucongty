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
    public partial class frmHopDongLaoDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDongLaoDong()
        {
            InitializeComponent();
        }
        HOPDONG_LAODONG _hopdong;
        NHANVIEN _nhanvien;
        bool _them;
        string _shd;
        private void frmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            txtSOHD.Enabled = !true;
            dtpNGAYBATDAU.Value=DateTime.Now;
            dtpNGAYKETTHUC.Value=DateTime.Now.AddYears(1);
            _them = false;
            _hopdong = new HOPDONG_LAODONG();
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
            
            dtpNGAYBATDAU.Enabled = !kt;
            dtpNGAYKETTHUC.Enabled = !kt;
            dtpNGAYKY.Enabled = !kt;
            spLANKY.Enabled = !kt;
            spHSL.Enabled = !kt;
            sNV.Enabled = !kt;
            speLuongCoBan.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _hopdong.getListFull();
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
                _hopdong.Delete(_shd);
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
                var maxSOHD = _hopdong.MaxSoHopDong();
                int so = int.Parse(maxSOHD.Substring(0, 5)) + 1;
                tb_HOPDONG hd = new tb_HOPDONG();
                hd.SOHD = so.ToString("00000") + @"/2024/HĐLĐ";
                hd.NGAYBATDAU = dtpNGAYBATDAU.Value;
                hd.NGAYKETTHUC = dtpNGAYKETTHUC.Value;
                hd.NGAYKY = dtpNGAYKY.Value;
                hd.THOIHAN = cbbTHOIHAN.Text;
                hd.HESOLUONG = double.Parse(spHSL.EditValue.ToString());
                hd.LANKY = int.Parse(spLANKY.EditValue.ToString());
                hd.MANV = int.Parse(sNV.EditValue.ToString());
                hd.LUONGCOBAN = double.Parse(speLuongCoBan.EditValue.ToString());
                hd.MACTY = 1;
                _hopdong.Add(hd);
            }
            else
            {
                var hd = _hopdong.getItem(_shd);
                hd.NGAYBATDAU = dtpNGAYBATDAU.Value;
                hd.NGAYKETTHUC = dtpNGAYKETTHUC.Value;
                hd.NGAYKY = dtpNGAYKY.Value;
                hd.THOIHAN = cbbTHOIHAN.Text;
                hd.HESOLUONG = double.Parse(spHSL.EditValue.ToString());
                hd.LANKY = int.Parse(spLANKY.EditValue.ToString());
                hd.MANV = int.Parse(sNV.EditValue.ToString());
                hd.LUONGCOBAN = double.Parse(speLuongCoBan.EditValue.ToString());
                hd.MACTY = 1;
                _hopdong.Update(hd);
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
                _shd = gvDanhSach.GetFocusedRowCellValue("SOHD").ToString();
                var hd = _hopdong.getItem(_shd);
                txtSOHD.Text = _shd;
                dtpNGAYBATDAU.Value = hd.NGAYBATDAU.Value;
                dtpNGAYKETTHUC.Value = hd.NGAYKETTHUC.Value;
                dtpNGAYKY.Value = hd.NGAYKY.Value;
                cbbTHOIHAN.Text = hd.THOIHAN;
                spHSL.Text = hd.HESOLUONG.ToString();
                spLANKY.Text = hd.LANKY.ToString();
                sNV.EditValue = hd.MANV;
                speLuongCoBan.EditValue = hd.LUONGCOBAN;
            }
        }
    }
}