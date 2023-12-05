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
        string _idClick;
        public frmQLSP()
        {
            InitializeComponent();
            _service = new SanPhamServices();
            LoadData(null);
            LoadCBB();
        }

        private void LoadData(string find)
        {
           // Type type = typeof(SanPham);
            dgvSanPham.Rows.Clear();
            dgvSanPham.ColumnCount = 11;
            int stt = 1;
            dgvSanPham.Columns[0].Name = "STT";
            //dgvSanPham.Columns[1].Name = "ID";
            dgvSanPham.Columns[1].Name = "Mã Sản Phẩm";
            dgvSanPham.Columns[2].Name = "Tên Sản Phẩm";
            dgvSanPham.Columns[3].Name = "Ngày Nhập";
            dgvSanPham.Columns[4].Name = "Số Lượng";
            dgvSanPham.Columns[5].Name = "Màu Sắc";
            dgvSanPham.Columns[6].Name = "Size";
            dgvSanPham.Columns[7].Name = "Chất Liệu";
            dgvSanPham.Columns[8].Name = "Thương Hiệu";
            dgvSanPham.Columns[9].Name = "Giá Tiền";
            dgvSanPham.Columns[10].Name = "Trạng Thái";
           
            foreach (var item in  _service.GetAll(find))
            {
                var getMauSac = _service.GetMauSac().FirstOrDefault(x=>x.MaMau==item.MaMau);
                var getThuongHieu= _service.GetThuongHieu().FirstOrDefault(x=>x.MaTh==item.MaTh);
                var getSize = _service.GetSize().FirstOrDefault(x=>x.MaSize==item.MaSize);  
                var getChatLieu = _service.GetChatLieu().FirstOrDefault(x=>x.MaChatLieu==item.MaChatLieu);
                dgvSanPham.Rows.Add(stt++, item.MaSp, item.TenSanPham, item.NgayNhap, item.SoLuong,getMauSac.TenMau,getSize.KichThuoc,
                    getChatLieu.LoaiChatLieu,getThuongHieu.TenThuongHieu,item.Gia, item.TrangThai);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _idClick = dgvSanPham.Rows[index].Cells[1].Value.ToString();
            txtboxIDSP.Text = dgvSanPham.Rows[index].Cells[1].Value.ToString();
            txtboxNameSP.Text = dgvSanPham.Rows[index].Cells[2].Value.ToString();
            dtpNgayNhap.Text = dgvSanPham.Rows[index].Cells[3].Value.ToString();
            txtboxSoLuong.Text = dgvSanPham.Rows[index].Cells[4].Value.ToString();
            cbbColor.Text = dgvSanPham.Rows[index].Cells[5].Value.ToString();
            cbbSize.Text = dgvSanPham.Rows[index].Cells[6].Value.ToString();
            cbbChatLieu.Text = dgvSanPham.Rows[index].Cells[7].Value.ToString();
            cbbThuongHieu.Text = dgvSanPham.Rows[index].Cells[8].Value.ToString();
            txtboxGiaTien.Text = dgvSanPham.Rows[index].Cells[9].Value.ToString();
            

            if (dgvSanPham.Rows[index].Cells[10].Value.Equals("Hết hàng"))
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
                && rbtnConHang.Text != string.Empty && txtboxGiaTien.Text != string.Empty)
                {
                    SanPham sp = new SanPham();
                    sp.TenSanPham = txtboxNameSP.Text;
                    sp.NgayNhap = dtpNgayNhap.Value;
                    sp.SoLuong = Convert.ToInt32(txtboxSoLuong.Text);
                    if(rbtnConHang.Checked)
                    {
                        sp.TrangThai = "Còn hàng";
                    }
                    else
                    {
                        sp.TrangThai = "Hết hàng";
                    }
                    sp.Gia = Convert.ToDouble( txtboxGiaTien.Text);
                   // sp.MaMau = 
                    sp.MaTh = cbbThuongHieu.Text;
                    sp.MaChatLieu = cbbChatLieu.Text;
                    sp.MaSize = cbbSize.Text;
                      MessageBox.Show("Thêm thành công");
                      _service.AddSP(sp);
                    LoadData(null);
                    LoadCBB();
                }
                else
                {
                 
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường");
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

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmHoaDon hoaDon = new frmHoaDon();
                hoaDon.ShowDialog();
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
                frmThongKe thongKe = new frmThongKe();
                thongKe.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void couponToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmDoiMatKhau doiMatKhau = new frmDoiMatKhau();
                doiMatKhau.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
