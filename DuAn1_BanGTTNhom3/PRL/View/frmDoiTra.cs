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
    public partial class frmDoiTra : Form
    {
        HoaDonServices _hoaDonServiecs;
        Guid? _idClick;
        public frmDoiTra()
        {
            InitializeComponent();
            _hoaDonServiecs = new HoaDonServices();
            LoadData(null);
        }
        public void LoadData(string find)
        {
            //Type type = typeof(HoaDon);


            dgtView.ColumnCount = 9;

            dgtView.Columns[0].Name = "STT";
            dgtView.Columns[1].Name = "Mã hóa đơn";
            dgtView.Columns[2].Name = "Ngày tạo";
            dgtView.Columns[3].Name = "Số lượng";
            dgtView.Columns[4].Name = "Đơn giá";
            dgtView.Columns[5].Name = "Tổng tiền";
            dgtView.Columns[6].Name = "Mã sản phẩm";
            dgtView.Columns[7].Name = "Mã nhân viên";
            dgtView.Columns[8].Visible = false;
            dgtView.Rows.Clear();
            int stt = 1;
            foreach (var item in _hoaDonServiecs.GetHoaDon(find))
            {
                var queryProduct = _hoaDonServiecs.GetSanPhams().FirstOrDefault(x => x.MaSp == item.MaSp);
                var queryStaff = _hoaDonServiecs.GetNhanViens().FirstOrDefault(x => x.MaNv == item.MaNv);
                var query = _hoaDonServiecs.GetHoaDonChiTiets().FirstOrDefault(x => x.MaHdct == item.MaHd);
                dgtView.Rows.Add(stt++, item.MaHd, item.NgayTao, query.SoLuong, query.DonGia, item.TongTien
                    , queryProduct.MaSp, queryStaff.MaNv, item.MaHd);
            }

        }

        private void dgtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _idClick = Guid.Parse(dgtView.Rows[index].Cells[8].Value.ToString());
            txtMaNv.Text = dgtView.Rows[index].Cells[7].Value.ToString();
            txtMaSp.Text = dgtView.Rows[index].Cells[6].Value.ToString();
            txtMaHD.Text = dgtView.Rows[index].Cells[1].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().ToLower().Length < 0 || txtSearch.Text == null)
            {
                LoadData(null);
            }
            else
            {
                LoadData(txtSearch.Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmDoiTra frmDoi = new frmDoiTra();

                frmDoi.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                frmHoaDon hoaDon = new frmHoaDon();
                hoaDon.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                MessageBox.Show("Có lỗi" + ex, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                MessageBox.Show("Có lỗi" + ex, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                MessageBox.Show("Có lỗi" + ex, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
