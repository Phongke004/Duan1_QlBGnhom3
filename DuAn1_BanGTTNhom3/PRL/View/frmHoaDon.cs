
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
            LoadData(null);
        }
        private void LoadData(string find)
        {
            Type type = typeof(HoaDon);

            dtgView.ColumnCount = 17;
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
           
            dtgView.Columns[16].Visible = false;


            dtgView.Rows.Clear();
            foreach (var i in _hoaDonServices.GetHoaDon(txtsearch.Text))
            {
                var queryNhanVien = _hoaDonServices.GetNhanViens().FirstOrDefault(i => i.MaNv == i.MaNv);
                var querySP = _hoaDonServices.GetSanPhams().FirstOrDefault(i => i.MaSp == i.MaSp);
                var queryVC = _hoaDonServices.GetVouchers().FirstOrDefault(i => i.MaVoucher == i.MaVoucher);
                var queryHDCT = _hoaDonServices.GetHoaDonChiTiets().FirstOrDefault(x => x.MaHd == i.MaHd);
                dtgView.Rows.Add(stt++, i.MaHd, i.NgayTao, i.TrangThai, i.TongTien, queryHDCT.TongTienSauVoucher, i.MaSp, querySP.TenSanPham,
                    queryHDCT.MaVoucher, queryVC.MoTa, i.MaNv, queryNhanVien.TenNhanVien, i.MaKh, queryHDCT.MaHdct, queryHDCT.SoLuong,
                    queryHDCT.DonGia);
            }

        }
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexof = e.RowIndex; if (indexof < 0) return;

            _idWhenClick = dtgView.Rows[indexof].Cells[1].Value.ToString();
            txtTienSauVC.Text = dtgView.Rows[indexof].Cells[5].Value.ToString();
            txtMaHoaDon.Text = dtgView.Rows[indexof].Cells[1].Value.ToString();
            cbbMaKH.Text = dtgView.Rows[indexof].Cells[12].Value.ToString();
            cbbMaNhanVien.Text = dtgView.Rows[indexof].Cells[10].Value.ToString();
            dtpkNgayTao.Value = DateTime.Parse(dtgView.Rows[indexof].Cells[2].Value.ToString());
            txtMaSP.Text = dtgView.Rows[indexof].Cells[7].Value.ToString();
            cbbTenSanPham.Text = dtgView.Rows[indexof].Cells[6].Value.ToString();
            cbbGiamGia.Text = dtgView.Rows[indexof].Cells[8].Value.ToString();
            cbbTrangthai.Text = dtgView.Rows[indexof].Cells[3].Value.ToString();
            txtSoSanPham.Text = dtgView.Rows[indexof].Cells[14].Value.ToString();
            txtDonGia.Text = dtgView.Rows[indexof].Cells[5].Value.ToString();
            txtTongTien.Text = dtgView.Rows[indexof].Cells[4].Value.ToString();

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

                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cbbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Voucher voucher = new Voucher();
            //try
            //{



            //    if (cbbGiamGia.Items != null)
            //    {
            //        txtTongTien.Text = ((int.Parse(txtSoSanPham.Text) * double.Parse(txtDonGia.Text)) - (int.Parse(txtSoSanPham.Text) * voucher.GiaTri * double.Parse(txtDonGia.Text))).ToString();

            //    }
            //    else
            //    {
            //        cbbGiamGia.SelectedItem = null;
            //    }





            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("chỉ được nhập số!!!!", "thông báo!", MessageBoxButtons.OK);
            //}
            TinhTongTien();
        }
        private void TinhTongTien()
        {




            try
            {
                if (!string.IsNullOrEmpty(txtSoSanPham.Text) && !string.IsNullOrEmpty(txtDonGia.Text))
                {
                    int soLuong = Convert.ToInt32(txtSoSanPham.Text);
                    double giaBan = Convert.ToDouble(txtDonGia.Text);

                    double tongTienBanDau = soLuong * giaBan;
                    txtTongTien.Text = tongTienBanDau.ToString();

                    // Kiểm tra xem đã chọn voucher chưa
                    if (cbbGiamGia.SelectedItem != null)
                    {
                        Voucher voucherChon = (Voucher)cbbGiamGia.SelectedItem;
                        double giamGia = Convert.ToDouble(voucherChon.GiaTri * soLuong * giaBan);
                        txtTongTien.Text = tongTienBanDau.ToString();

                        double tongTienSauVoucher = tongTienBanDau - giamGia;
                        txtTienSauVC.Text = tongTienSauVoucher.ToString();
                    }
                    else
                    {
                        // Nếu không có voucher, tổng tiền sau voucher bằng tổng tiền ban đầu
                        txtTienSauVC.Text = tongTienBanDau.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng số tiền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try
            //{
            //    if (!string.IsNullOrEmpty(txtSoSanPham.Text) && !string.IsNullOrEmpty(txtDonGia.Text))
            //    {
            //        int soLuong = Convert.ToInt32(txtSoSanPham.Text);
            //        double giaBan = Convert.ToDouble(txtDonGia.Text);

            //        double tongTien = soLuong * giaBan;

            //        Kiểm tra xem đã chọn voucher chưa
            //        if (cbbGiamGia.SelectedItem != null)
            //        {
            //            Voucher voucherChon = (Voucher)cbbGiamGia.SelectedItem;
            //            tongTien -= Convert.ToDouble(voucherChon.GiaTri * soLuong * giaBan);
            //        }

            //        txtTongTien.Text = tongTien.ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tính tổng số tiền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public void LoadComBoBox()
        {
            List<Voucher> vouchers = _hoaDonServices.GetVouchers();
            cbbGiamGia.DataSource = vouchers;
            cbbGiamGia.DisplayMember = "MoTa";
            cbbGiamGia.SelectedIndex = -1;




            List<SanPham> sanPhams = _hoaDonServices.GetSanPhams();
            cbbTenSanPham.DataSource = sanPhams;
            cbbTenSanPham.DisplayMember = "TenSanPham";
            cbbTenSanPham.SelectedIndex = -1;

            //cbb nhan viên
            List<NhanVien> nhanViens = _hoaDonServices.GetNhanViens();
            cbbMaNhanVien.DataSource = nhanViens;
            cbbMaNhanVien.DisplayMember = "MaNv";
            cbbMaNhanVien.SelectedIndex = -1;

            //bbGiamGia.DataSource = _hoaDonServices.GetVouchers();
            //Cbb khach hang
            List<KhachHang> khachHangs = _hoaDonServices.GetKhachHang();
            cbbMaKH.DataSource = khachHangs;
            cbbMaKH.DisplayMember = "MaKH";
            cbbMaKH.SelectedIndex = -1;



        }



        private void btnAddHoadon_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();

                if (txtMaSP.Text != string.Empty && cbbTenSanPham.Text != string.Empty)
                {

                    hoaDon.NgayTao = Convert.ToDateTime(dtpkNgayTao.Value);
                    hoaDon.TrangThai = cbbTrangthai.SelectedItem.ToString();
                    hoaDon.TongTien = Convert.ToDouble(txtTongTien.Text);
                   
                    hoaDon.MaSp = txtMaSP.Text;
              
                    hoaDon.MaNv = cbbMaNhanVien.SelectedItem.ToString();
                    hoaDon.MaKh = cbbMaKH.SelectedItem.ToString();
                    _hoaDonServices.AddsHD(hoaDon);
                    MessageBox.Show("Thêm thành công");
                    LoadData(null);






                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    MessageBox.Show("Hãy nhập đầy đủ các trường");
                }
                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
                if (txtSoSanPham.Text != string.Empty && txtDonGia.Text != string.Empty )
                {
                    hoaDonChiTiet.SoLuong =Convert.ToInt32( txtSoSanPham.Text);
                    hoaDonChiTiet.DonGia = Convert.ToInt32(txtDonGia.Text);
                }

            }
            catch (Exception ex)
            {

            }
        }
        private void txtSoSanPham_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void txtSoSanPham_TextChanged(object sender, EventArgs e)
        {

            //var voucher = _hoaDonServices.GetIDVouchers(null);
            //try
            //{


            //    txtSoSanPham.Text = "";
            //    if (txtSoSanPham.Text != null && txtDonGia.Text != null)
            //    {

            //        txtTongTien.Text = (int.Parse(txtSoSanPham.Text) * double.Parse(txtDonGia.Text)).ToString();
            //        if (cbbGiamGia.SelectedItem != null)
            //        {
            //            txtTongTien.Text = ((int.Parse(txtSoSanPham.Text) * double.Parse(txtDonGia.Text)) - (int.Parse(txtSoSanPham.Text) * voucher.GiaTri * double.Parse(txtDonGia.Text))).ToString();

            //        }


            //    }
            //    else
            //    {
            //        MessageBox.Show("chỉ được nhập số!!!!", "thông báo!", MessageBoxButtons.OK);
            //    }


            //}

            //catch (Exception)
            //{
            //    return;

            //}
            TinhTongTien();




        }
        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtDonGia.Text = "";
            if (cbbTenSanPham.SelectedItem != null)
            {
                var sanPham = (SanPham)cbbTenSanPham.SelectedItem;
                txtMaSP.Text = sanPham.MaSp;
                txtDonGia.Text = sanPham.Gia.ToString();
            }
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLSP sanPham = new frmQLSP();
                sanPham.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLNV nhanVien = new frmQLNV();
                nhanVien.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }



        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmThongKe thongKe = new frmThongKe();
                thongKe.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmVoucher voucher = new frmVoucher();
                voucher.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void quảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmDoiTra doiTra = new frmDoiTra();
                doiTra.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void cuoponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmCoupon coupon = new frmCoupon();
                coupon.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLNV nhanVien = new frmQLNV();
                nhanVien.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }



        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

            if (cbbTenSanPham.SelectedItem != null)
            {
                var sanPham = (SanPham)cbbTenSanPham.SelectedItem;
                txtDonGia.Text = sanPham.Gia.ToString();
            }
        }

        private void txtTienSauVC_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }


    }
}
