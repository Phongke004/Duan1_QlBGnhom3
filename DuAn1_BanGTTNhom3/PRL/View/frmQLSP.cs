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
using Size = DAL.DomainClass.Size;

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
            LoadCBB();
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
            cbbColor.Text = dgvSanPham.Rows[index].Cells[6].Value.ToString();
            cbbSize.Text = dgvSanPham.Rows[index].Cells[7].Value.ToString();
            cbbChatLieu.Text = dgvSanPham.Rows[index].Cells[8].Value.ToString();
            cbbThuongHieu.Text = dgvSanPham.Rows[index].Cells[9].Value.ToString();
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
                if (txtboxNameSP.Text != string.Empty && dtpNgayNhap.Text != string.Empty && txtboxSoLuong.Text != string.Empty
                && rbtnConHang.Text != string.Empty && cbbColor.Text != string.Empty && cbbSize.Text != string.Empty
                && cbbChatLieu.Text != string.Empty && cbbThuongHieu.Text != string.Empty && txtboxGiaTien.Text != string.Empty)
                {
                    SanPham sp = new SanPham();
                    ChiTietSanPham ctsp = new ChiTietSanPham();
                    sp.TenSanPham = txtboxNameSP.Text;
                    sp.NgayNhap = dtpNgayNhap.Value;
                    sp.SoLuong = Convert.ToInt32(txtboxSoLuong.Text);
                    ctsp.MaMau = cbbColor.Text;
                    ctsp.MaSize = cbbSize.Text;
                    ctsp.MaChatLieu = cbbChatLieu.Text;
                    ctsp.MaTh = cbbThuongHieu.Text;
                    sp.Gia = Convert.ToInt32(txtboxGiaTien.Text);
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
            cbbColor.Text = "";
            cbbSize.Text = "";
            cbbChatLieu.Text = "";
            cbbThuongHieu.Text = "";
            txtboxGiaTien.Text = "";
            rbtnConHang.Checked = false;
            rbtnHetHang.Checked = false;
        }
        private void LoadCBB()
        {
            List<MauSac> ms = _service.GetMauSac();
            cbbColor.DataSource = ms;
            cbbColor.DisplayMember = "TenMau";

            List<Size> sz = _service.GetSize();
            cbbSize.DataSource = sz;
            cbbSize.DisplayMember = "KichThuoc";

            List<ChatLieu> cl = _service.GetChatLieu();
            cbbChatLieu.DataSource = cl;
            cbbChatLieu.DisplayMember = "LoaiChatLieu";

            List<ThuongHieu> th = _service.GetThuongHieu();
            cbbThuongHieu.DataSource = th;
            cbbThuongHieu.DisplayMember = "TenThuongHieu";
        }
    }
}
