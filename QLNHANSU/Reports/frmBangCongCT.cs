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
using BusinessLayer;
using DevExpress.XtraReports.UI;
namespace QLNHANSU.Reports
{
    public partial class frmBangCongCT : DevExpress.XtraEditors.XtraForm
    {

        public frmBangCongCT()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        BANGCONG_NV_CT _bcct_nv;

        private void frmBangCongCT_Load(object sender, EventArgs e)
        {
            _nhanvien = new NHANVIEN();
            _bcct_nv=new BANGCONG_NV_CT();
            loadNhanVien();
            cbo_kicong.SelectedIndex = DateTime.Now.Month-1;
        }
        void loadNhanVien()
        {
            cbo_NhanVien.DataSource = _nhanvien.getList();
            cbo_NhanVien.DisplayMember = "HOTEN";
            cbo_NhanVien.ValueMember= "MANV";

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            var lst = _bcct_nv.getBangCongCT(DateTime.Now.Year*100 + int.Parse(cbo_kicong.Text) , int.Parse(cbo_NhanVien.SelectedValue.ToString()));
            rptBangCongCT rpt =new rptBangCongCT(lst);
            rpt.ShowPreviewDialog();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}