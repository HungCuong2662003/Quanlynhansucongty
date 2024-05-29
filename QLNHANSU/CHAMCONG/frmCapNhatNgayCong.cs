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
    public partial class frmCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNgayCong()
        {
            InitializeComponent();
        }
        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _cNgay;
        KYCONGCHITIET _kcct;
        BANGCONG_NV_CT _bcct_nv;
        frmBangCongChiTiet frmBCCC = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];
        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCHITIET();
            _bcct_nv = new BANGCONG_NV_CT();
            blID.Text = _manv.ToString();
            blHOTEN.Text = _hoten.ToString();
            string nam = _makycong.ToString().Substring(0, 4);
            string thang = _makycong.ToString().Substring(4);
            string ngay =_ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            cldNgayCong.SetDate(_d);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            string _valueChamCong = rdgChamCong.Properties.Items[rdgChamCong.SelectedIndex].Value.ToString();
            string _valueNgayNghi = rdgThoiGianNghi.Properties.Items[rdgThoiGianNghi.SelectedIndex].Value.ToString();
            string fieldName = "D" + _cNgay.ToString();
            var kcct = _kcct.getItem(_makycong, _manv);
            double? tongngaycong = kcct.TONGNGAYCONG;
            double? tongngayphep = kcct.NGAYPHEP;
            double? tongngaykhongphep = kcct.NGHIKHONGPHEP;
            double? tongngayle = kcct.CONGNGAYLE;
            if (cldNgayCong.SelectionRange.Start.Year * 100 + cldNgayCong.SelectionRange.Start.Month != +_makycong)
            {
                MessageBox.Show("Thực Hiện Chấm Công Không Đúng. Vui Lòng Kiểm Tra Lại!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Cuong_Functions.execQuery("UPDATE tb_KYCONGCHITIET SET " + fieldName + "='" + _valueChamCong + "'WHERE MAKYCONG=" + _makycong + "AND MANV=" + _manv);

            tb_BANGCONG_NHANVIEN_CHITIET bcctnv = _bcct_nv.getItem(_makycong, _manv, cldNgayCong.SelectionStart.Day);
            bcctnv.KYHIEU = _valueChamCong;
            
            switch (_valueChamCong)
            {
                case "P":
                    if(bcctnv.KYHIEU == _valueChamCong)
                   
                    if (_valueNgayNghi == "NN")
                    {
                        bcctnv.NGAYPHEP = 1;
                        bcctnv.NGAYCONG = 0;
                       
                    }
                    else
                    {
                        bcctnv.NGAYPHEP = 0.5;
                        bcctnv.NGAYCONG = 0.5;
                        
                    }
                    break;
                case "V":
                    if (bcctnv.KYHIEU == _valueChamCong)

                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGHIKHONGPHEP = 1;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.NGHIKHONGPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;

                        }
                    break;
                case "CNL":
                    if (bcctnv.KYHIEU == _valueChamCong)

                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.CONGNGAYLE = 1;
                            bcctnv.NGAYCONG = 1;

                        }
                        else
                        {
                            bcctnv.CONGNGAYLE = 0.5;
                            bcctnv.NGAYCONG = 1;

                        }
                    break;
                case "CNCN":
                    if (bcctnv.KYHIEU == _valueChamCong)

                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.CONGCHUNHAT = 1;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.CONGCHUNHAT = 0.5;
                            bcctnv.NGAYCONG = 0;

                        }
                    break;
                default:
                    break;

            }
            _bcct_nv.Update(bcctnv);
            double tnc = _bcct_nv.tongngaycong(_makycong, _manv);
            double tnp = _bcct_nv.tongngayphep(_makycong, _manv);
            double tnkp = _bcct_nv.tongnghikhongphep(_makycong, _manv);
            double cnl = _bcct_nv.congngayle(_makycong, _manv);
            double cnchunhat = _bcct_nv.congngaychunhat(_makycong, _manv);
            kcct.CONGCHUNHAT = cnchunhat;
            kcct.CONGNGAYLE = cnl;
            kcct.NGHIKHONGPHEP = tnkp;
            kcct.NGAYPHEP = tnp;
            kcct.TONGNGAYCONG = tnc;
            _kcct.Update(kcct);
            frmBCCC.loadBangCong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cldNgayCong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cNgay =cldNgayCong.SelectionRange.Start.Day;
        }
    }
}