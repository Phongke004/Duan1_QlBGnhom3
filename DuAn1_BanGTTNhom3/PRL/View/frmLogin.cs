
using BUS.Services;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class frmLogin : Form
    {
        private NhanVienServices _service;
        private string user, pass;
        private bool isExitApplication = false;
        public frmLogin()
        {
            _service = new NhanVienServices();  
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginNv();
            }
            catch (Exception)
            {

                MessageBox.Show("Đăng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void LoginNv()
        {
            bool result = checkAccount();
            if (!result) { return; }
            try
            {
                frmHoaDon login = new frmHoaDon();
                this.Hide();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.Yes)
                {
                    isExitApplication = true;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đăng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool checkAccount()
        {
            bool rs = check();
            var checkAD = _service.CheckExistsNV(user, pass);

            if (!checkAD)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                return false;
            }
            else

            {
                return true;
            }
        }
        private bool check()
        {
            user = txtUser.Text.Trim();
            pass = txtPassWord.Text.Trim();
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return false;
            }
            return true;
        }
        private bool checkText()
        {
            var user = txtUser.Text.Trim();
            var pass = txtPassWord.Text.Trim();
            return string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pass);
        }

    }
}
