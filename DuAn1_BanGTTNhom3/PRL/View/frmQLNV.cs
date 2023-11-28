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
    public partial class frmQLNV : Form
    {
        private QLNVSevice sevice;

        Guid? _idWhenClick;
        public frmQLNV()
        {
            InitializeComponent();
            sevice = new QLNVSevice();
            LoadData(null);
        }

        public void LoadData(string find)
        {
            Type type = typeof(NhanVien);
            dgvNhanVien.Rows.Clear();
            dgvNhanVien.ColumnCount = type.GetProperties().Length + 1;
            int stt = 1;
            dgvNhanVien.Columns[0].Name = "STT";
            dgvNhanVien.Columns[1].Name = "ID";
            dgvNhanVien.Columns[2].Name = "Mã nhân viên";
            dgvNhanVien.Columns[3].Name = "Tên";
            dgvNhanVien.Columns[4].Name = "Địa chỉ";
            dgvNhanVien.Columns[5].Name = "SDT";
            dgvNhanVien.Columns[6].Name = "Email";
            dgvNhanVien.Columns[7].Name = "Giới tính";
            dgvNhanVien.Columns[8].Name = "Trạng thái";
            dgvNhanVien.Columns[9].Name = "Ngày sinh";
            dgvNhanVien.Columns[10].Name = "Ca làm";
            dgvNhanVien.Columns[11].Name = "Chức vụ";
            dgvNhanVien.Columns[12].Name = "Mật khẩu";
            dgvNhanVien.Columns[1].Visible = false;
            foreach (var nv in sevice.GetNVs(find))
            {
                var item = sevice.GetChucVus().FirstOrDefault(x => x.IdChucVu == nv.MaChucVu);
                var e = sevice.GetCaLams().FirstOrDefault(x => x.IdCaLamViec == nv.MaCa);
                dgvNhanVien.Rows.Add(stt++, nv.IdNhanVien, nv.MaNv, nv.TenNhanVien, nv.DiaChi, nv.SoDienThoai, nv.Email, nv.GioiTinh, nv.TrangThai, nv.NgaySinh, e.MaCa, item.MaCv, nv.MatKhau);
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien();

            nv.MaNv = txtPasswork.Text;
            nv.TenNhanVien = txtTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            nv.TrangThai = radioButtonHD.Checked ? "Hoạt Động" : "Không Hoạt Động";
            DateTime NgaySinh = dtpNgaySinh.Value;
            nv.MaChucVu = nv.MaCa;
            nv.MaChucVu = nv.MaChucVu;
            nv.MatKhau = txtEmail.Text;
            var option = MessageBox.Show("Xác nhận muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(sevice.Add(nv));
                MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadData(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //int stt = 1;
            //dgvNhanVien.ColumnCount = 13;
            //dgvNhanVien.Columns[0].Name = "STT";
            //dgvNhanVien.Columns[1].Name = "ID";
            //dgvNhanVien.Columns[2].Name = "Mã nhân viên";
            //dgvNhanVien.Columns[3].Name = "Tên";
            //dgvNhanVien.Columns[4].Name = "Địa chỉ";
            //dgvNhanVien.Columns[5].Name = "SDT";
            //dgvNhanVien.Columns[6].Name = "Email";
            //dgvNhanVien.Columns[7].Name = "Giới tính";
            //dgvNhanVien.Columns[8].Name = "Trạng thái";
            //dgvNhanVien.Columns[9].Name = "Ngày sinh";
            //dgvNhanVien.Columns[10].Name = "Ca làm";
            //dgvNhanVien.Columns[11].Name = "Chức vụ";
            //dgvNhanVien.Columns[12].Name = "Mật khẩu";
            //dgvNhanVien.Columns[1].Visible = false;
            //dgvNhanVien.Rows.Clear();
            //foreach (var nv in sevice.GetNVs(txtSearch.Text))
            //{
            //    dgvNhanVien.Rows.Add(stt++, nv.IdNhanVien, nv.MaNv, nv.TenNhanVien, nv.DiaChi, nv.SoDienThoai, nv.Email, nv.GioiTinh, nv.TrangThai, nv.NgaySinh, nv.MaCa, nv.MaChucVu, nv.MatKhau);
            //}
        }
    }
}