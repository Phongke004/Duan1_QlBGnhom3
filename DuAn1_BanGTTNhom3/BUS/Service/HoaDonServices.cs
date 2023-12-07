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
        HoaDonReps _repos;
        public HoaDonServices()
        {
            _repos = new HoaDonReps();
        }

        public string AddsHD(HoaDon hd)
        {
            if (_repos.AddHD(hd)== true)
            {
                return "Thêm thành công";

            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string AddsHDCT(HoaDonChiTiet hdct)
        {
            if (_repos.AddHDCT(hdct))
            {
                return "thêm thành công";

            }
            else
            {
                return "thêm thất bại";
            }
        }

        public string DeletesHD(HoaDon hd)
        {
            var clone = _repos.GetHoaDons().FirstOrDefault(s => s.MaNv == hd.MaNv);
            
            if (_repos.DeleteHD(clone))
            {
                return " Xóa thành công";
            }
            else
            {
                return " Xóa thất bại";
            }
        }

        public string DeletesHDCT(HoaDonChiTiet hdct)
        {
            var clone = _repos.GetHoaDonChiTiets().FirstOrDefault(s => s.MaHd == hdct.MaHd);

            if (_repos.DeleteHDCT(clone))
            {
                return " Xóa thành công";
            }
            else
            {
                return " Xóa thất bại";
            }
        }

      
        

        public List<HoaDon> GetHoaDon(string find)
        {
            if (find == null)
            {
                return _repos.GetHoaDons();
            }
            else
            {
                return _repos.GetHoaDons().Where(x => x.MaHd.Contains(find)).ToList();
            }
          
        }

        public List<HoaDonChiTiet> GetHoaDonChiTiets(string search)
        {
          
            if (search == null)
            {
                return _repos.GetHoaDonChiTiets();
            }
            else
            {
                return _repos.GetHoaDonChiTiets().Where(x => x.MaHd.Contains(search)).ToList();
            }
        }

        public Voucher GetIDVouchers(string MaVC)
        {
            return _repos.GetIDVoucher(MaVC);
        }

        public List<KhachHang> GetKhachHang()
        {
            return _repos.GetKhachHang();
        }

        public List<NhanVien> GetNhanViens()
        {
          return _repos.GetNhanViens();
        }

        public List<SanPham> GetSanPhams()
        {
            return _repos.GetSanPhams();
        }

        public List<Voucher> GetVouchers()
        {
            return _repos.GetVouchers();
        }

        public string UpdatesHD(HoaDon hd)
        {
            var clone = _repos.GetHoaDons().FirstOrDefault(s => s.MaNv == hd.MaNv);
            clone.NgayTao = hd.NgayTao;
            clone.TrangThai = hd.TrangThai;
            clone.TongTien = hd.TongTien;
          

            if (_repos.UpdateHD(hd))
            {
                return " sửa thành công";
            }
            else
            {
                return " sửa thất bại";
            }
        }

        public string UpdatesHDCT(HoaDonChiTiet hdct)
        {
            var clone = _repos.GetHoaDonChiTiets().FirstOrDefault(s => s.MaHd == hdct.MaHd);
            clone.SoLuong = hdct.SoLuong;
            clone.DonGia = hdct.DonGia;
            clone.TongTienSauVoucher = hdct.TongTienSauVoucher;
            clone.MaHd = hdct.MaHd;

            if (_repos.UpdateHDCT(hdct) == true)
            {
                return " sửa thành công";
            }
            else
            {
                return " sửa thất bại";
            }
        }
    }
}
