using BUS.IService;
using DAL.DomainClass;
using DAL.IRepositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class HoaDonServices : IHoaDonServices
    {
        HoaDonReps _hoadon;
        public HoaDonServices()
        {
            _hoadon = new HoaDonReps();
        }

        public List<HoaDon> GetHoaDon(string find)
        {
            if (find == null)
            {
                return _hoadon.GetHoaDons();
            }
            return _hoadon.GetHoaDons().Where(x => x.MaHd.Trim().ToLower().Contains(find.ToLower())).ToList();
        }

        public List<HoaDonChiTiet> GetHoaDonChiTiets()
        {
          return _hoadon.GetHoaDonChiTiets();
        }

        public List<NhanVien> GetNhanViens()
        {
          return _hoadon.GetNhanViens();
        }

        public List<SanPham> GetSanPhams()
        {
            return _hoadon.GetSanPhams();
        }
    }
}
