using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface ISanPhamServices
    {
        public bool AddSP(SanPham sp);
        public bool UpdateSP(SanPham sp);
        public List<SanPham> GetAll(string find);
        public List<ChiTietSanPham> GetChiTietSP();
        public List<HoaDon> GetHoaDon();
        public List<MauSac> GetMauSac();
        public List<Size> GetSize();
        public List<ChatLieu> GetChatLieu();
        public List<ThuongHieu> GetThuongHieu();
    }
}