using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IHoaDonServices
    {
        public List<HoaDon> GetHoaDon(string find);
        public List<HoaDonChiTiet> GetHoaDonChiTiets();
        public List <NhanVien > GetNhanViens();
        public List<SanPham> GetSanPhams();
        public List<KhachHang> GetKhachHang();
        public string UpdatesHD(HoaDon hd);
        public string DeletesHD(HoaDon hd);
        public string AddsHD(HoaDon hd);
        public string UpdatesHDCT(HoaDonChiTiet hdct);
        public string DeletesHDCT(HoaDonChiTiet hdct);
        public string AddsHDCT(HoaDonChiTiet hdct);
        public List<Voucher> GetVouchers();
        public Voucher GetIDVouchers(string MaVC);
       

    }
}
