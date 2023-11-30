
using BUS.Service;
using DAL.Context;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PRL.View
{
    public partial class frmHoaDon : Form
    {
        private HoaDonServices _hoaDonServices;
        private bool isExitApplication = false;
        Guid _idClick;
        public frmHoaDon()
        {
            InitializeComponent();
            _hoaDonServices = new HoaDonServices();
            LoadComBoBox();


        }

        private void mnStripDoiMk_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            this.Hide();

            frmDoiMatKhau.ShowDialog();

        }

        private void MnStripDangXuat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    isExitApplication = true;
                    frmLogin frmLogin = new frmLogin();
                    this.Hide();
                    frmLogin.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    isExitApplication = true;
                    this.Close();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            try
            {
                if (txtSoLuong.Text != null && cbbGiamGia.Items == null)
                {
                    txtTongTien.Text = (int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text)).ToString();

                }
                else if (txtSoLuong.Text != null && cbbGiamGia.Items != null)
                {
                    txtTongTien.Text = ((int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text)) - (int.Parse(txtSoLuong.Text) * voucher.GiaTri * double.Parse(txtDonGia.Text))).ToString();

                }
                else if (txtSoLuong.Text == null && cbbGiamGia.Items != null)
                {
                    txtSoLuong.Text = "";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Chỉ được nhập số!!!!", "Thông báo!", MessageBoxButtons.OK);
            }
        }

        private void cbbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadComBoBox()
        {
            List<Voucher> vouchers = _hoaDonServices.GetVouchers();
            cbbGiamGia.DataSource = vouchers;
            cbbGiamGia.DisplayMember = "MoTa";
            //bbGiamGia.DataSource = _hoaDonServices.GetVouchers();

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
