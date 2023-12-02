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
        string _idClick;
        public frmQLNV()
        {
            InitializeComponent();
            sevice = new QLNVSevice();
            LoadData(null);
            LoadCBO();


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
                var item = sevice.GetChucVus().FirstOrDefault(x => x.MaCv == nv.MaChucVu);
                var e = sevice.GetCaLams().FirstOrDefault(x => x.MaCa == nv.MaCa);
                dgvNhanVien.Rows.Add(stt++, nv.MaNv, nv.MaNv, nv.TenNhanVien, nv.DiaChi, nv.SoDienThoai, nv.Email, nv.GioiTinh, nv.TrangThai, nv.NgaySinh, e.MaCa, item.MaCv, nv.MatKhau);
            }

        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _idClick = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtPasswork.Text = dgvNhanVien.Rows[index].Cells[12].Value.ToString();
            cboChucVu.Text = dgvNhanVien.Rows[index].Cells[11].Value.ToString();
            cboCaLam.Text = dgvNhanVien.Rows[index].Cells[10].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[index].Cells[9].Value.ToString();
            radioButtonHD.Text = dgvNhanVien.Rows[index].Cells[8].Value.ToString();
            radioButtonNam.Text = dgvNhanVien.Rows[index].Cells[7].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtTen.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtMa.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
        }


        public void LoadCBO()
        {
            List<CaLamViec> CaLam = sevice.GetCaLams();
            cboCaLam.DataSource = CaLam;
            cboCaLam.DisplayMember = "MaCa";

            List<ChucVu> ChucVu = sevice.GetChucVus();
            cboChucVu.DataSource = ChucVu;
            cboChucVu.DisplayMember = "MaCv";
        }

        //private void btnSua_Click_1(object sender, EventArgs e)
        //{
        //    var nv = new NhanVien();


        //    nv.TenNhanVien = txtTen.Text;
        //    nv.DiaChi = txtDiaChi.Text;
        //    nv.SoDienThoai = txtSDT.Text;
        //    nv.Email = txtEmail.Text;
        //    nv.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
        //    nv.TrangThai = radioButtonHD.Checked ? "Hoạt Động" : "Không Hoạt Động";
        //    nv.NgaySinh = dtpNgaySinh.Value;
        //    nv.MaChucVu = cboChucVu.Text;
        //    nv.MaCa = cboCaLam.Text;
        //    nv.MatKhau = txtPasswork.Text;
        //    var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
        //    if (option == DialogResult.Yes)
        //    {
        //        MessageBox.Show(sevice.Update(nv));

        //    }
        //    else
        //    {

        //        return;
        //    }
        //    LoadData(null);
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    txtMa.Text = "";
        //    txtTen.Text = "";
        //    txtDiaChi.Text = "";
        //    txtSDT.Text = "";
        //    txtEmail.Text = "";
        //    radioButtonHD.Checked = false;
        //    radioButtonNam.Checked = false;
        //    dtpNgaySinh.Text = "";
        //    cboCaLam.Text = "";
        //    cboChucVu.Text = "";
        //    txtPasswork.Text = "";
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text != string.Empty && txtDiaChi.Text != string.Empty && txtEmail.Text != string.Empty && txtSDT.Text != string.Empty
                    && radioButtonNam.Text != string.Empty && radioButtonHD.Text != string.Empty && dtpNgaySinh.Text != string.Empty
                    && cboChucVu.Text != string.Empty && cboCaLam.Text != string.Empty && txtPasswork.Text != string.Empty)
                {
                    NhanVien nv = new NhanVien();
                    nv.TenNhanVien = txtTen.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.SoDienThoai = txtSDT.Text;
                    nv.Email = txtEmail.Text;
                    nv.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                    nv.TrangThai = radioButtonHD.Checked ? "Hoạt Động" : "Không Hoạt Động";
                    nv.NgaySinh = dtpNgaySinh.Value;
                    nv.MaChucVu = cboChucVu.Text;
                    nv.MaCa = cboCaLam.Text;
                    nv.MatKhau = txtPasswork.Text;
                    sevice.Add(nv);
                    MessageBox.Show("Thêm thành công");
                    LoadData(null);
                    LoadCBO();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien();


            nv.TenNhanVien = txtTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            nv.TrangThai = radioButtonHD.Checked ? "Hoạt Động" : "Không Hoạt Động";
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.MaChucVu = cboChucVu.Text;
            nv.MaCa = cboCaLam.Text;
            nv.MatKhau = txtPasswork.Text;
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(sevice.Update(nv));

            }
            else
            {

                return;
            }
            LoadData(null);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            radioButtonHD.Checked = false;
            radioButtonNam.Checked = false;
            dtpNgaySinh.Text = "";
            cboCaLam.Text = "";
            cboChucVu.Text = "";
            txtPasswork.Text = "";
        }

    }
}