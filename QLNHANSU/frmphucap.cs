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
    public partial class frmphucap : DevExpress.XtraEditors.XtraForm
    {
        public frmphucap()
        {
            InitializeComponent();
        }
        PHUCAP _phucap;
        bool _them;
        int _id;
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtPC.Enabled = !kt;
            speSOTIEN.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _phucap.getList();
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
                tb_PHUCAP bp = new tb_PHUCAP();
                bp.TENPC = txtPC.Text;
                bp.SOTIEN=double.Parse(speSOTIEN.Value.ToString());
                _phucap.Add(bp);
            }
            else
            {

                var pc = _phucap.getList(_id);

                pc.TENPC = txtPC.Text;
                pc.SOTIEN = double.Parse(speSOTIEN.Value.ToString());
                _phucap.Update(pc);
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

        private void frmphucap_Load(object sender, EventArgs e)
        {
            _them = false;
            _phucap = new PHUCAP();
            _showHide(true);
            loadData();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDPC").ToString());
            txtPC.Text = gvDanhSach.GetFocusedRowCellValue("TENPC").ToString();
            speSOTIEN.Value = Convert.ToDecimal(gvDanhSach.GetFocusedRowCellValue("SOTIEN").ToString());
        }
    }
}