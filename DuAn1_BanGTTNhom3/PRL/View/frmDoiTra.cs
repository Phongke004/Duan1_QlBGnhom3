﻿using BUS.Service;
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
        string _idClick;
        bool isExitApplication = false;
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
                
                var queryStaff = _hoaDonServiecs.GetNhanViens().FirstOrDefault(x => x.MaNv == item.MaNv);
                var query = _hoaDonServiecs.GetHoaDonChiTiets(null).FirstOrDefault(x => x.MaHd == item.MaHd);
                dgtView.Rows.Add(stt++, item.MaHd, item.NgayTao, query.SoLuong, query.DonGia, item.TongTien
                    , queryStaff.MaNv, item.MaHd);
            }

        }

        private void dgtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _idClick = dgtView.Rows[index].Cells[8].Value.ToString();
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


                frmDoi frmDoi = new frmDoi();

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

        private void btnTra_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLSP sanPham = new frmQLSP();
                sanPham.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void quảnLýKhuyếnMạiToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
