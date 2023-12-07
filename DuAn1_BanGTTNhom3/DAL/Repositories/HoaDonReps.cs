using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonReps : IHoaDonReps
    {
        MyContext _connect;
        public HoaDonReps()
        {
            _connect = new MyContext();
        }
        
        public bool AddHD(HoaDon hd, KhachHang kh)
        {
            if (GetHoaDons().Count != 0 && GetKhachHang().Count !=0)
            {
                var maxid = _connect.Dois.Max(x => x.MaDoi);
                int nextid = Convert.ToInt32(maxid.Substring(2)) + 1;
                hd.MaHd = "HD" + nextid.ToString("D3");
                kh.MaKh = "KH" + nextid.ToString("D3");
            }
            else
            {
                hd.MaHd = "HD001";
                kh.MaKh = "KH001";
            }
            _connect.Add(hd);
            _connect.SaveChanges();
            return true;
        }

        public bool AddHDs(HoaDon hd)
        {
            _connect.Add(hd);
            _connect.SaveChanges();
            return true;
        }

        public bool AddHDCT(HoaDonChiTiet hdct)
        {
            _connect.Add(hdct);
            _connect.SaveChanges();
            return true;
        }

        public bool DeleteHD(HoaDon hd)
        {
            _connect.Remove(hd);
            _connect.SaveChanges();
            return true;
        }

        public bool DeleteHDCT(HoaDonChiTiet hdct)
        {
            _connect.Remove(hdct);
            _connect.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetHoaDonChiTiets()
        {
            return _connect.HoaDonChiTiets.ToList();
        }

        public List<HoaDon> GetHoaDons()
        {
            return _connect.HoaDons.ToList();
        }

        public Voucher GetIDVoucher(string MaVC)
        {
            return _connect.Vouchers.FirstOrDefault(i => i.MaVoucher == MaVC);
        }

        public List<KhachHang> GetKhachHang()
        {
            return _connect.KhachHangs.ToList();
        }

        public List<NhanVien> GetNhanViens()
        {
           return _connect.NhanViens.ToList();
        }

        public List<SanPham> GetSanPhams()
        {
          return _connect.SanPhams.ToList();
        }

        public List<Voucher> GetVouchers()
        {
            return _connect.Vouchers.ToList();

        }

        public bool UpdateHD(HoaDon hd)
        {
            _connect.Update(hd);
            _connect.SaveChanges();
            return true;
        }

        public bool UpdateHDCT(HoaDonChiTiet hdct)
        {
            _connect.Update(hdct);
            _connect.SaveChanges();
            return true;
        }
    }
}
