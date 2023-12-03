using BUS.IService;
using DAL.Context;
using DAL.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SanPhamServices : ISanPhamServices
    {
        private SanPhamRepositories _repos;
        public SanPhamServices()
        {
            _repos = new SanPhamRepositories();
        }
        public string AddSP(SanPham sp)
        {
            if (_repos.Add(sp) == true)
            {
                return ("Thêm thành công");
            }
            else
            {

            }
            {
                return ("Thêm thất bại");
            }
        }

        public List<SanPham> GetAll(string find)
        {
            if (find == null)
            {
                return _repos.GetAll();
            }
            return _repos.GetAll().Where(x => x.MaSp.Trim().ToLower().Contains(find.ToLower())).ToList();
        }

        public List<ChatLieu> GetChatLieu()
        {
            return _repos.GetChatLieu();
        }

        public List<ChiTietSanPham> GetChiTietSP()
        {
            return _repos.GetChiTietSP();
        }

        public List<HoaDon> GetHoaDon()
        {
            return _repos.GetHoaDon();
        }

        public List<MauSac> GetMauSac()
        {
            return _repos.GetMauSac();
        }

        public List<Size> GetSize()
        {
            return _repos.GetSize();
        }

        public List<ThuongHieu> GetThuongHieu()
        {
            return _repos.GetThuongHieu();
        }

        public string UpdateSP(SanPham sp)
        {
            //var clone = _repos.GetAll().FirstOrDefault(x => x.MaSp == sp.MaSp);
            //clone.TenSanPham = sp.TenSanPham;
            //clone.NgayNhap = sp.NgayNhap;
            //clone.SoLuong = sp.SoLuong;
            //clone.TenMau = sp.TenMau;
            //clone.KichThuoc = sp.KichThuoc;
            //clone.LoaiChatLieu = sp.LoaiChatLieu;
            //clone.TenThuongHieu = sp.TenThuongHieu;
            //clone.TongTien = sp.TongTien;
            //clone.TrangThai = sp.TrangThai;
            //if (_repos.Update(clone) == true)
            //{
            //    return (" Sửa thành công");
            //}
            //else
            //{
            //    return (" Sửa thất bại");
            //}
            throw new NotImplementedException();
        }
    }
}
