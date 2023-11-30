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
    public partial class frmQLSP : Form
    {
        private SanPhamServices _service;
        public frmQLSP()
        {
            InitializeComponent();
            _service = new SanPhamServices();
            LoadData(null);
        }

        private void LoadData(string find)
        {
            Type type = typeof(SanPham);
            dgvSanPham.Rows.Clear();
            dgvSanPham.ColumnCount = 12;
            int stt = 1;
            dgvSanPham.Columns[0].Name = "STT";
            dgvSanPham.Columns[1].Name = "ID";
            dgvSanPham.Columns[2].Name = "Mã Sản Phẩm";
            dgvSanPham.Columns[3].Name = "Tên Sản Phẩm";
            dgvSanPham.Columns[4].Name = "Ngày Nhập";
            dgvSanPham.Columns[5].Name = "Số Lượng";
            dgvSanPham.Columns[6].Name = "Màu Sắc";
            dgvSanPham.Columns[7].Name = "Size";
            dgvSanPham.Columns[8].Name = "Chất Liệu";
            dgvSanPham.Columns[9].Name = "Thương Hiệu";
            dgvSanPham.Columns[10].Name = "Giá Tiền";
            dgvSanPham.Columns[11].Name = "Trạng Thái";
            dgvSanPham.Columns[1].Visible = false;
            foreach (var sp in _service.GetAll(find))
            {
                var item = _service.GetChiTietSP().FirstOrDefault(x => x.MaSp == sp.IdSanPham);
                var e = _service.GetHoaDon().FirstOrDefault(x => x.MaHd == sp.MaSp);
                dgvSanPham.Rows.Add(stt++, sp.IdSanPham, sp.MaSp, sp.TenSanPham, sp.NgayNhap, sp.SoLuong,
                    item.MaMau, item.MaSize, item.MaChatLieu, item.MaTh, item.Gia, sp.TrangThai);
            }
        }
    }
}
