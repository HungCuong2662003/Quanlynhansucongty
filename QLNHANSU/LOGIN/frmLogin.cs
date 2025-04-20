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

namespace QLNHANSU.LOGIN
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private QLNHANSUEntities db = new QLNHANSUEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            string Usernam = txtUSERNAME.Text;
            string Password = txtPASS.Text;
            CheckLogin(Usernam, Password);
        }
        private void CheckLogin(string Usernam, string Password)
        {
            var user = db.tb_LOGIN.Where(u => u.USERNAME.Equals(Usernam)).ToList();
            if (user.Count() > 0)
            {
                if (user[0].PASS.Equals(Password))
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    this.Hide();
                    new MainForm().Show();
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Không Đúng !");
                }
            }
            else
            {
                MessageBox.Show("Không Tồn Tại Tài Khoản Trong Hệ Thống!");
            }
        }
        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}