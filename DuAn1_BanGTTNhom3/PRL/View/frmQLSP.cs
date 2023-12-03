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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRL.View
{
    public partial class frmQLSP : Form
    {
        private SanPhamServices _service;
        string _cellclick;
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
            foreach (var sp in _service.GetChiTietSP())
            {
                var item = _service.GetAll(find).FirstOrDefault(x => x.MaSp == sp.MaSp);
                var e = _service.GetHoaDon().FirstOrDefault(x => x.MaSp == sp.MaSp);
                var a = _service.GetMauSac().FirstOrDefault(x => x.MaMau == sp.MaMau);
                var b = _service.GetSize().FirstOrDefault(x => x.MaSize == sp.MaSize);
                var c = _service.GetChatLieu().FirstOrDefault(x => x.MaChatLieu == sp.MaChatLieu);
                var d = _service.GetThuongHieu().FirstOrDefault(x => x.MaTh == sp.MaTh);
                dgvSanPham.Rows.Add(stt++, sp.MaSp, sp.MaSp, item.TenSanPham, item.NgayNhap, item.SoLuong,
                    a.TenMau, b.KichThuoc, c.LoaiChatLieu, d.TenThuongHieu, e.TongTien, item.TrangThai);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _cellclick = dgvSanPham.Rows[index].Cells[1].Value.ToString();
            txtboxIDSP.Text = dgvSanPham.Rows[index].Cells[2].Value.ToString();
            txtboxNameSP.Text = dgvSanPham.Rows[index].Cells[3].Value.ToString();
            dtpNgayNhap.Text = dgvSanPham.Rows[index].Cells[4].Value.ToString();
            txtboxSoLuong.Text = dgvSanPham.Rows[index].Cells[5].Value.ToString();
            txtboxColor.Text = dgvSanPham.Rows[index].Cells[6].Value.ToString();
            txtboxSize.Text = dgvSanPham.Rows[index].Cells[7].Value.ToString();
            txtboxChatLieu.Text = dgvSanPham.Rows[index].Cells[8].Value.ToString();
            txtboxThuongHieu.Text = dgvSanPham.Rows[index].Cells[9].Value.ToString();
            txtboxGiaTien.Text = dgvSanPham.Rows[index].Cells[10].Value.ToString();
            if (dgvSanPham.Rows[index].Cells[11].Value.Equals("Hết hàng"))
            {
                rbtnHetHang.Checked = true;
            }
            else
            {
                rbtnConHang.Checked = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxIDSP.Text != string.Empty && txtboxNameSP.Text != string.Empty && dtpNgayNhap.Text != string.Empty && txtboxSoLuong.Text != string.Empty)
                //&& rbtnConHang.Text != string.Empty && txtboxColor.Text != string.Empty && txtboxSize.Text != string.Empty
                //&& txtboxChatLieu.Text != string.Empty && txtboxThuongHieu.Text != string.Empty && txtboxGiaTien.Text != string.Empty)
                {
                    SanPham sp = new SanPham();
                    sp.TenSanPham = txtboxNameSP.Text;
                    sp.NgayNhap = dtpNgayNhap.Value;
                    sp.SoLuong = Convert.ToInt32(txtboxSoLuong.Text);
                    //sp.TenMau = txtboxColor.Text;
                    //sp.KichThuoc = txtboxSize;
                    //sp.LoaiChatLieu = txtboxChatLieu;
                    //sp.TenThuongHieu = txtboxThuongHieu;
                    //sp.TongTien = txtboxGiaTien;
                    sp.TrangThai = rbtnConHang.Checked ? "Còn hàng" : "Hết hàng";
                    _service.AddSP(sp);
                    MessageBox.Show("Thêm thành công");
                    LoadData(null);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    MessageBox.Show("Hãy nhập đầy đủ các trường");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxIDSP.Text = "";
            txtboxNameSP.Text = "";
            dtpNgayNhap.Text = "";
            txtboxSoLuong.Text = "";
            txtboxColor.Text = "";
            txtboxSize.Text = "";
            txtboxChatLieu.Text = "";
            txtboxThuongHieu.Text = "";
            txtboxGiaTien.Text = "";
            rbtnConHang.Checked = false;
            rbtnHetHang.Checked = false;
        }
    }
}
