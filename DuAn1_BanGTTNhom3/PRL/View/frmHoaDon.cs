
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



            dtgView.ColumnCount = 8;
            int stt = 1;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã HD";
            dtgView.Columns[2].Name = "Ngày tạo";
            dtgView.Columns[3].Name = "Trạng thái";
            dtgView.Columns[4].Name = "Tổng tiền";
            dtgView.Columns[5].Name = "Mã NV";
            dtgView.Columns[5].Visible = false;
            dtgView.Columns[6].Name = "Tên nhân viên";
            dtgView.Columns[7].Name = "Mã KH";


            dtgView.Rows.Clear();
            foreach (var i in _hoaDonServices.GetHoaDon(txtsearch.Text))
            {
                var queryNhanVien = _hoaDonServices.GetNhanViens().FirstOrDefault(i => i.MaNv == i.MaNv);
                var querySP = _hoaDonServices.GetSanPhams().FirstOrDefault(i => i.MaSp == i.MaSp);


                dtgView.Rows.Add(stt++, i.MaHd, i.NgayTao, i.TrangThai, i.TongTien,
                       i.MaNv, queryNhanVien.TenNhanVien, i.MaKh);
            }


        }
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexof = e.RowIndex; if (indexof < 0) return;

            _idWhenClick = dtgView.Rows[indexof].Cells[1].Value.ToString();

            txtMaHoaDon.Text = dtgView.Rows[indexof].Cells[1].Value.ToString();
            cbbMaKH.Text = dtgView.Rows[indexof].Cells[7].Value.ToString();
            cbbMaNhanVien.Text = dtgView.Rows[indexof].Cells[5].Value.ToString();
            dtpkNgayTao.Value = DateTime.Parse(dtgView.Rows[indexof].Cells[2].Value.ToString());
            cbbTrangthai.Text = dtgView.Rows[indexof].Cells[3].Value.ToString();
            txtTongTien.Text = dtgView.Rows[indexof].Cells[4].Value.ToString();

        }
        private void dtgviewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexof = e.RowIndex; if (indexof < 0) return;

            _idWhenClick = dtgviewHD.Rows[indexof].Cells[1].Value.ToString();
            txtMaHDCT.Text = dtgviewHD.Rows[indexof].Cells[1].Value.ToString();
            txtTienSauVC.Text = dtgviewHD.Rows[indexof].Cells[6].Value.ToString();
            cbbTenSanPham.Text = dtgviewHD.Rows[indexof].Cells[3].Value.ToString();

            txtMaSP.Text = dtgviewHD.Rows[indexof].Cells[2].Value.ToString();

            cbbGiamGia.Text = dtgviewHD.Rows[indexof].Cells[8].Value.ToString();
            txtSoSanPham.Text = dtgviewHD.Rows[indexof].Cells[4].Value.ToString();
            txtDonGia.Text = dtgviewHD.Rows[indexof].Cells[5].Value.ToString();
            cbbMaHD.Text = dtgviewHD.Rows[indexof].Cells[9].Value.ToString();

        }
        private void LoadDataHDCT()
        {

            dtgviewHD.ColumnCount = 10;
            int stt = 1;
            dtgviewHD.Columns[0].Name = "STT";
            dtgviewHD.Columns[1].Name = "Mã HDCT";
            dtgviewHD.Columns[1].Visible = false;
            dtgviewHD.Columns[2].Name = "Mã sản phẩm";
            dtgviewHD.Columns[2].Visible = false;
            dtgviewHD.Columns[3].Name = "Tên sản phẩm";
            dtgviewHD.Columns[4].Name = "Số Lượng";
            dtgviewHD.Columns[5].Name = "Đơn Giá ";
            dtgviewHD.Columns[6].Name = "Tiền sau Voucher";
            dtgviewHD.Columns[7].Name = "Mã VC";
            dtgviewHD.Columns[7].Visible = false;
            dtgviewHD.Columns[8].Name = "Mô tả voucher";
            dtgviewHD.Columns[9].Name = "Mã HD";
            dtgviewHD.Rows.Clear();
            foreach (var i in _hoaDonServices.GetHoaDonChiTiets(txtsearch.Text))
            {

                var queryVC = _hoaDonServices.GetVouchers().FirstOrDefault(i => i.MaVoucher == i.MaVoucher);
                var querySanPham = _hoaDonServices.GetSanPhams().FirstOrDefault(i => i.MaSp == i.MaSp);
                dtgviewHD.Rows.Add(stt++, i.MaHdct, i.MaSp, querySanPham.TenSanPham, i.SoLuong, i.DonGia, i.TongTienSauVoucher, i.MaVoucher, queryVC.MoTa, i.MaHd);
            }
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
            // hóa đơn
            List<HoaDon> hoaDon = _hoaDonServices.GetHoaDon(null);
            cbbMaHD.DataSource = hoaDon;
            cbbMaHD.DisplayMember = "MaHD";
            cbbMaHD.SelectedIndex = -1;


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

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtMaSP.Text != "" && cbbTrangthai.Text != "" && cbbMaKH.Text != "")
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.NgayTao = Convert.ToDateTime(dtpkNgayTao.Value);
                    hoaDon.TrangThai = cbbTrangthai.Text;
                    hoaDon.TongTien = Convert.ToDouble(txtTongTien.Text);

                    hoaDon.MaNv = cbbMaNhanVien.Text;
                    hoaDon.MaKh = cbbMaKH.Text;

                    _hoaDonServices.AddsHD(hoaDon);
                    MessageBox.Show("Thêm thành công");
                    LoadData(null);
                    txtMaHoaDon.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    MessageBox.Show("Hãy nhập đầy đủ các trường");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã sai rồi");
            }
        }

        private void btnAddHoadon_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtSoSanPham.Text != string.Empty && cbbMaHD.Text != string.Empty)
                {
                    HoaDonChiTiet hDCT = new HoaDonChiTiet();
                    hDCT.MaSp = txtMaSP.Text;
                    hDCT.SoLuong = Convert.ToInt32(txtSoSanPham.Text);
                    hDCT.DonGia = Convert.ToDouble(txtDonGia.Text);

                    hDCT.TongTienSauVoucher = Convert.ToDouble(txtTienSauVC.Text);
                    hDCT.MaHd = cbbMaHD.Text;


                    UpdateSoLuong();
                    _hoaDonServices.AddsHDCT(hDCT);

                    TinhTongTien();
                    LoadData(null);
                    LoadDataHDCT();

                    MessageBox.Show("Thêm thành công");



                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    MessageBox.Show("Hãy nhập đầy đủ các trường");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Thông báo :" + ex, "Thông báo ", MessageBoxButtons.OK);
            }
        }
        private void UpdateSoLuong()
        {
            try
            {
                int soLuong =Convert.ToInt32( txtSoSanPham.Text);
                if (soLuong == null)
                {
                    return;
                }
                else
                {
                    foreach (var  i in _hoaDonServices.GetHoaDonChiTiets(null))
                    {
                        var getSoLuong = _hoaDonServices.GetSanPhams().FirstOrDefault(x => x.MaSp == i.MaSp);
                        int upDateSoLuongSp = Convert.ToInt32(getSoLuong.SoLuong - soLuong);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Thông báo :" + ex, "Thông báo ", MessageBoxButtons.OK);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtTienSauVC.Clear();
            txtMaHoaDon.ReadOnly = false;
            cbbMaKH.Text = "";
            cbbMaNhanVien.Text = "";
            dtpkNgayTao.Text = "";
            txtMaSP.Clear();
            cbbTenSanPham.Text = "";
            cbbGiamGia.Text = "";
            cbbTrangthai.Text = "";
            txtSoSanPham.Text = "";
            txtDonGia.Clear();
            txtTongTien.Text = "";

        }
        private void btnHienThiHD_Click(object sender, EventArgs e)
        {

            LoadDataHDCT();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.MaHd = _idWhenClick;
            hd.NgayTao = Convert.ToDateTime(dtpkNgayTao.Text);
            hd.TrangThai = cbbTrangthai.Text;
            hd.TongTien = Convert.ToDouble(txtTongTien.Text);
            hd.MaKh = cbbTrangthai.Text;
            hd.MaNv = cbbMaNhanVien.Text;
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn Sửa không", "Xác nhận ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_hoaDonServices.UpdatesHD(hd));
            }
            else
            {
                return;
            }
            LoadData(null);
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();

            hd.MaHd = _idWhenClick;
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn Xóa không", "Xác nhận ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_hoaDonServices.DeletesHD(hd));
            }
            else
            {
                return;
            }
            LoadData(null);
        }

        private void btnXoaHDCT_Click(object sender, EventArgs e)
        {
            HoaDonChiTiet hdct = new HoaDonChiTiet();

            hdct.MaHdct = _idWhenClick;
            //update lai so luong kho hang khi xoa
            SanPham suaSL = _hoaDonServices.GetSanPhams().Where(p => p.MaSp.Equals(txtMaSP.Text)).SingleOrDefault();
            suaSL.SoLuong = suaSL.SoLuong + int.Parse(txtSoSanPham.Text);
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn Xóa không", "Xác nhận ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_hoaDonServices.DeletesHDCT(hdct));
            }
            else
            {
                return;
            }
            LoadDataHDCT();
        }

        private void btnUpdateHDCT_Click(object sender, EventArgs e)
        {

        }


        private void cbbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
