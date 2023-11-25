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
            Type type = typeof(HoaDon);
            dgtView.Rows.Clear();
            dgtView.ColumnCount = type.GetProperties().Length+1;
            
            dgtView.Columns[0].Name = "STT";
            dgtView.Columns[1].Name = "Mã hóa đơn";
            dgtView.Columns[2].Name = "Ngày tạo";
            dgtView.Columns[3].Name = "Số lượng";
            dgtView.Columns[4].Name = "Đơn giá";
            dgtView.Columns[5].Name = "Tổng tiền";
            dgtView.Columns[5].Name = "Mã sản phẩm";
            dgtView.Columns[7].Name = "Mã nhân viên";
            dgtView.Columns[8].Visible = false;
            int stt = 1;
            foreach(var item in _hoaDonServiecs.GetHoaDon(find))
            {
                var query = _hoaDonServiecs.GetHoaDonChiTiets().FirstOrDefault(x => x.IdHoaDonCt == item.IdHoaDon);
                dgtView.Rows.Add(stt++,item.MaHd,item.NgayTao,query.SoLuong,query.DonGia,item.TongTien,item.MaSp,item.MaNv);
            }
        }

    }
}
