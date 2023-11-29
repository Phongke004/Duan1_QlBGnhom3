using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IHoaDonReps
    {
        public List<HoaDon> GetHoaDons();
        public List<HoaDonChiTiet> GetHoaDonChiTiets();
        public List<NhanVien> GetNhanViens();
        public List<SanPham> GetSanPhams();

      
        public bool UpdateHD(HoaDon hd);
        public bool DeleteHD(HoaDon hd);
        public bool AddHD(HoaDon hd);
        public bool UpdateHDCT(HoaDonChiTiet hdct);
        public bool DeleteHDCT(HoaDonChiTiet hdct);
        public bool AddHDCT(HoaDonChiTiet hdct);

    }
}
