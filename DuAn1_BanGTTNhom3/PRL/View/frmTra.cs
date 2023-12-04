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
    public partial class frmTra : Form
    {
        private DoiTraServiecs _service;
        string _idClick;
        public frmTra()
        {
            _service = new DoiTraServiecs();
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Type type = typeof(Tra);

            dtgview.ColumnCount = type.GetProperties().Length + 1;
            int stt = 1;
            dtgview.Columns[0].Name = "STT";
            dtgview.Columns[1].Name = "Mã trả";
            dtgview.Columns[2].Name = "Trạng thái";
            dtgview.Columns[3].Name = "Ngày trả";
            dtgview.Columns[4].Name = "Lý do";
            dtgview.Columns[5].Name = "Mã HDCT";
            dtgview.Columns[5].Visible = false;
            dtgview.Columns[6].Visible = false;


            dtgview.Rows.Clear();
            foreach (var i in _service.GetTras(txtSearch.Text))
            {
                dtgview.Rows.Add(stt++, i.MaTra, i.TrangThai, i.NgayDoi, i.LyDo, i.MaHdct);
            }
        }

        private void dtgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _idClick = dtgview.Rows[index].Cells[1].Value.ToString();
            txtMaTRa.Text = dtgview.Rows[index].Cells[1].Value.ToString();
            txtTrangThai.Text = dtgview.Rows[index].Cells[2].Value.ToString();
            dtpkNgayTra.Value = DateTime.Parse(dtgview.Rows[index].Cells[3].Value.ToString());
            txtLyDo.Text = dtgview.Rows[index].Cells[4].Value.ToString();
            //  txtMaHDCT.Text = dtgView.Rows[index].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tra tra = new Tra();
            tra.TrangThai = txtTrangThai.Text;
            tra.NgayDoi = dtpkNgayTra.Value;
            tra.LyDo = txtLyDo.Text;
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.UpdateTras(tra));

            }
            else
            {

                return;
            }
            LoadData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idClick == null)
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu để xóa");

                }
                else
                {
                    var confirmDele = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmDele == DialogResult.Yes)
                    {
                        _service.DeleteTra(_idClick);
                        LoadData();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
