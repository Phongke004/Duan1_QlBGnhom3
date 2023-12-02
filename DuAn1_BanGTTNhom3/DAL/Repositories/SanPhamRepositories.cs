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
    public class SanPhamRepositories : ISanPhamRepositories
    {
        private MyContext _db;
        public SanPhamRepositories()
        {
            _db = new MyContext();
        }
        public bool Add(SanPham sp)
        {
            if (GetAll().Count != 0)
            {
                var maxid = _db.NhanViens.Max(x => x.MaNv);
                int nextid = Convert.ToInt32(maxid.Substring(2)) + 1;
                sp.MaSp = "SP" + nextid.ToString("D3");
            }
            else
            {
                sp.MaSp = "SP001";
            }
            _db.Add(sp);
            _db.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _db.SanPhams.ToList();
        }

        public List<ChatLieu> GetChatLieu()
        {
            return _db.ChatLieus.ToList();
        }

        public List<ChiTietSanPham> GetChiTietSP()
        {
            return _db.ChiTietSanPhams.ToList();
        }

        public List<HoaDon> GetHoaDon()
        {
            return _db.HoaDons.ToList();
        }

        public List<MauSac> GetMauSac()
        {
            return _db.MauSacs.ToList();
        }

        public List<Size> GetSize()
        {
            return _db.Sizes.ToList();
        }

        public List<ThuongHieu> GetThuongHieu()
        {
            return _db.ThuongHieus.ToList();
        }

        public bool Update(SanPham sp)
        {
            //try
            //{
            //    if (sp == null) return false;
            //    var a = _db.SanPhams.FirstOrDefault(x => x.MaSp == sp.MaSp);
            //    var b = _db.ChiTietSanPhams.FirstOrDefault(x => x.MaSp == sp.MaSp);
            //    var c = _db.HoaDons.FirstOrDefault(x => x.MaSp == sp.MaSp);
            //    var d = _db.MauSacs.FirstOrDefault(x => x.MaMau == sp.MaMau);
            //    var e = _db.Sizes.FirstOrDefault(x => x.MaSize == sp.MaSize);
            //    var f = _db.ChatLieus.FirstOrDefault(x => x.MaChatLieu == sp.MaChatLieu);
            //    var g = _db.ThuongHieus.FirstOrDefault(x => x.MaTh == sp.MaTh);
            //    if (a == null) return false;
            //    if (b == null) return false;
            //    if (c == null) return false;
            //    if (d == null) return false;
            //    if (e == null) return false;
            //    if (f == null) return false;
            //    if (g == null) return false;
            //    a.TenSanPham = sp.TenSanPham;
            //    a.NgayNhap = sp.NgayNhap;
            //    a.SoLuong = sp.SoLuong;
            //    d.TenMau = sp.TenMau;
            //    e.KichThuoc = ;
            //    b.DiaChi = sp.DiaChi;
            //    d.MatKhau = nv.MatKhau;
            //    d.TrangThai = nv.TrangThai;
            //    d.MaChucVu = nv.MaChucVu;
            //    d.MaCa = nv.MaCa;
            //    _dbcontext.NhanViens.Update(nv);
            //    _dbcontext.SaveChanges();
            //    return true;
            //}
            //catch (Exception)
            //{

            //    return false;
            //}
            throw new NotImplementedException();
        }
    }
}
