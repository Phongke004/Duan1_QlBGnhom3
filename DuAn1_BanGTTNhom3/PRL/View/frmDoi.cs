using BUS.IService;
using BUS.Service;
using PRL.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class frmDoi : Form
    {
        DoiTraServiecs _doiTraServiecs;
        HoaDonServices _hoaDonServices;
        string _idClick;
        public frmDoi()
        {
            InitializeComponent();
            _doiTraServiecs = new DoiTraServiecs();
            _hoaDonServices = new HoaDonServices();
            LoadData(null);
        }

        private void frmDoi_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(string find)
        {

            dtgView.ColumnCount = 7;

            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã Đổi";
            dtgView.Columns[2].Name = "Ngày tạo";
            dtgView.Columns[3].Name = "Trạng thái";
            dtgView.Columns[4].Name = "Tên sản phẩm";
            dtgView.Columns[5].Name = "Lý do";
            dtgView.Columns[6].Name = "Mã hóa đơn CT";
            dtgView.Rows.Clear();
            int stt = 1;
            foreach (var item in _doiTraServiecs.GetDois(find))
            {
                dtgView.Rows.Add(stt++, item.MaDoi, item.NgayDoi, item.TrangThai, item.DoiSangSp, item.LyDo, item.MaHdct);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
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

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _idClick = dtgView.Rows[index].Cells[1].Value.ToString();
            txtMaDoi.Text = dtgView.Rows[index].Cells[1].Value.ToString();
            cbTrangThai.Text = dtgView.Rows[index].Cells[3].Value.ToString();
            ptkNgayDoi.Value = DateTime.Parse(dtgView.Rows[index].Cells[2].Value.ToString());
            txtLyDo.Text = dtgView.Rows[index].Cells[4].Value.ToString();
            txtMaHDCT.Text = dtgView.Rows[index].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLyDo.Text = "";
            txtMaDoi.Text = " ";
            txtMaHDCT.Text = " ";
            cbTrangThai.Text = " ";
          //  ptkNgayDoi.Text = " ";
            
        }
    }
}
