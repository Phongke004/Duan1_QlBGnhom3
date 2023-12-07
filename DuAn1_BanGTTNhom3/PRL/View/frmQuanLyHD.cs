using BUS.IService;
using BUS.Service;
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
    public partial class frmQuanLyHD : Form
    {
        HoaDonServices _hoaDonServices;
        string _idWhenclick;
        public frmQuanLyHD()
        {
            _hoaDonServices = new HoaDonServices();
            InitializeComponent();
        }

        private void btnHIenthi_Click(object sender, EventArgs e)
        {
            LoadDataHD();
            LoadDataHDCT();
        }
        private void LoadDataHD()
        {

            dtgvHoaDon.ColumnCount = 10;
            int stt = 1;
            dtgvHoaDon.Columns[0].Name = "STT";
            dtgvHoaDon.Columns[1].Name = "Mã HD";
            dtgvHoaDon.Columns[2].Name = "Ngày tạo";
            dtgvHoaDon.Columns[3].Name = "Trạng thái";
            dtgvHoaDon.Columns[4].Name = "Tổng tiền";
            dtgvHoaDon.Columns[5].Name = "Mã SP";
            dtgvHoaDon.Columns[5].Visible = false;
            dtgvHoaDon.Columns[6].Name = "Tên sản phẩm";

            dtgvHoaDon.Columns[7].Name = "Mã NV";
            dtgvHoaDon.Columns[7].Visible = false;
            dtgvHoaDon.Columns[8].Name = "Tên nhân viên";
            dtgvHoaDon.Columns[9].Name = "Mã KH";







            dtgvHoaDon.Rows.Clear();
            foreach (var i in _hoaDonServices.GetHoaDon(txtsearch.Text))
            {
                var queryNhanVien = _hoaDonServices.GetNhanViens().FirstOrDefault(i => i.MaNv == i.MaNv);
                var querySP = _hoaDonServices.GetSanPhams().FirstOrDefault(i => i.MaSp == i.MaSp);


                dtgvHoaDon.Rows.Add(stt++, i.MaHd, i.NgayTao, i.TrangThai, i.TongTien, i.MaSp, querySP.TenSanPham,
                   i.MaNv, queryNhanVien.TenNhanVien, i.MaKh);
            }
        }
        private void LoadDataHDCT()
        {

            dtgvHDCT.ColumnCount = 8;
            int stt = 1;
            dtgvHDCT.Columns[0].Name = "STT";
            dtgvHDCT.Columns[1].Name = "Mã HDCt";

            dtgvHDCT.Columns[2].Name = "Số Lượng";
            dtgvHDCT.Columns[3].Name = "Đơn Giá ";
            dtgvHDCT.Columns[4].Name = "Tiền sau Voucher";
            dtgvHDCT.Columns[5].Name = "Mã VC";
            dtgvHDCT.Columns[5].Visible = false;
            dtgvHDCT.Columns[6].Name = "Mô tả voucher";
            dtgvHDCT.Columns[7].Name = "Ma HD";





            dtgvHDCT.Rows.Clear();
            foreach (var i in _hoaDonServices.GetHoaDonChiTiets(txtsearch.Text))
            {

                var queryVC = _hoaDonServices.GetVouchers().FirstOrDefault(i => i.MaVoucher == i.MaVoucher);

                dtgvHDCT.Rows.Add(stt++, i.MaHdct, i.SoLuong, i.DonGia, i.TongTienSauVoucher, i.MaVoucher, queryVC.MoTa, i.MaHd);
            }
        }
        private void dtgvHDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexof = e.RowIndex; if (indexof < 0) return;

            _idWhenclick = dtgvHoaDon.Rows[indexof].Cells[1].Value.ToString();
        }

        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexof = e.RowIndex; if (indexof < 0) return;

            _idWhenclick = dtgvHDCT.Rows[indexof].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.MaHd = _idWhenclick;
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn Xóa không", "Xác nhận ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_hoaDonServices.DeletesHD(hd));
            }
            else
            {
                return;
            }
            LoadDataHD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonChiTiet hd = new HoaDonChiTiet();
            hd.MaHdct = _idWhenclick;
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn Xóa không", "Xác nhận ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show(_hoaDonServices.DeletesHDCT(hd));
            }
            else
            {
                return;
            }
            LoadDataHDCT();
        }
    }
}
