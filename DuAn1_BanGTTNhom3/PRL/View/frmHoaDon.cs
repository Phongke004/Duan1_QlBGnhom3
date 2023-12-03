
using BUS.Service;
using DAL.Context;
using DAL.DomainClass;



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        string _idWhenClick;
        public frmHoaDon()
        {
            InitializeComponent();
            _hoaDonServices = new HoaDonServices();
            LoadComBoBox();


        }
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Type type = typeof(HoaDon);

            dtgView.ColumnCount = 18;
            int stt = 1;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã HD";
            dtgView.Columns[2].Name = "Ngày tạo";
            dtgView.Columns[3].Name = "Trạng thái";
            dtgView.Columns[4].Name = "Tổng tiền";
            dtgView.Columns[5].Name = "Tiền sau Voucher";
            dtgView.Columns[6].Name = "Mã SP";
            dtgView.Columns[6].Visible = false;
            dtgView.Columns[7].Name = "Tên sản phẩm";
            dtgView.Columns[8].Name = "Mã VC";
            dtgView.Columns[8].Visible = false;
            dtgView.Columns[9].Name = "Mô tả voucher";
            dtgView.Columns[10].Name = "Mã NV";
            dtgView.Columns[10].Visible = false;
            dtgView.Columns[11].Name = "Tên nhân viên";
            dtgView.Columns[12].Name = "Mã KH";
            dtgView.Columns[13].Name = "Mã HDCT";
            dtgView.Columns[13].Visible = false;
            dtgView.Columns[14].Name = "Số Lượng";
            dtgView.Columns[15].Name = "Đơn Giá ";
            dtgView.Columns[16].Name = "Ghi chú";
            dtgView.Columns[17].Visible = false;


            dtgView.Rows.Clear();
            foreach (var i in _hoaDonServices.GetHoaDon(txtSearch.Text))
            {
                var queryNhanVien = _hoaDonServices.GetNhanViens().FirstOrDefault(i => i.MaNv == i.MaNv);
                var querySP = _hoaDonServices.GetSanPhams().FirstOrDefault(i => i.MaSp == i.MaSp);
                var queryVC = _hoaDonServices.GetVouchers().FirstOrDefault(i => i.MaVoucher == i.MaVoucher);
                var queryHDCT = _hoaDonServices.GetHoaDonChiTiets().FirstOrDefault(x => x.MaHd == i.MaHd);
                dtgView.Rows.Add(stt++, i.MaHd, i.NgayTao, i.TrangThai, i.TongTien, i.TongTienSauVoucher, i.MaSp, querySP.TenSanPham, i.MaVoucher, queryVC.MoTa, i.MaNv, queryNhanVien.TenNhanVien, i.MaKh, queryHDCT.MaHdct, queryHDCT.SoLuong, queryHDCT.DonGia, queryHDCT.GhiChu);
            }

        }
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexof = e.RowIndex; if (indexof < 0) return;

            _idWhenClick = dtgView.Rows[indexof].Cells[1].Value.ToString();
            //txtThanhTien.Text = dtgView.Rows[indexof].Cells[5].Value.ToString();
            txtMaHoaDon.Text = dtgView.Rows[indexof].Cells[1].Value.ToString();
            txtMaKhachHang.Text = dtgView.Rows[indexof].Cells[12].Value.ToString();
            txtMaNhanVien.Text = dtgView.Rows[indexof].Cells[10].Value.ToString();
            dtpkNgayTao.Value = DateTime.Parse(dtgView.Rows[indexof].Cells[2].Value.ToString());
            txtTenSanPham.Text = dtgView.Rows[indexof].Cells[7].Value.ToString();
            cbbMaSP.Text = dtgView.Rows[indexof].Cells[6].Value.ToString();
            cbbGiamGia.Text = dtgView.Rows[indexof].Cells[8].Value.ToString();
            cbbTrangthai.Text = dtgView.Rows[indexof].Cells[3].Value.ToString();
            txtSoSanPham.Text = dtgView.Rows[indexof].Cells[14].Value.ToString();
            txtDonGia.Text = dtgView.Rows[indexof].Cells[5].Value.ToString();
            txtTongTien.Text = dtgView.Rows[indexof].Cells[4].Value.ToString();
            
        }
        private void dtgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            





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

        private void txtSoLuong_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSoSanPham_TextChanged(object sender, EventArgs e)
        {
            //Voucher voucher = new Voucher();
            //try
            //{
            //    if (txtSoLuong.Text != null && cbbGiamGia.Items == null)
            //    {
            //        txtTongTien.Text = (int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text)).ToString();

            //    }
            //    else if (txtSoLuong.Text != null && cbbGiamGia.Items != null)
            //    {
            //        txtTongTien.Text = ((int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text)) - (int.Parse(txtSoLuong.Text) * voucher.GiaTri * double.Parse(txtDonGia.Text))).ToString();

            //    }
            //    else if (txtSoLuong.Text == null && cbbGiamGia.Items != null)
            //    {
            //        txtSoLuong.Text = "";
            //    }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Chỉ được nhập số!!!!", "Thông báo!", MessageBoxButtons.OK);
            //}
        }

        private void btnAddHoadon_Click(object sender, EventArgs e)
        {

        }

        
    }
}
