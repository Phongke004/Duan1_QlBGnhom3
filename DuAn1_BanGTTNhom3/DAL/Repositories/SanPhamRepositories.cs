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
                var maxid = _db.SanPhams.Max(x => x.MaSp);
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
            //    var a = _db.ChiTietSanPhams.FirstOrDefault(x => x.Maspct == sp.MaSp);
            //    var b = _db.MauSacs.FirstOrDefault(x => x.MaMau == sp.MaMau);
            //    var c = _db.Sizes.FirstOrDefault(x => x.MaSize == sp.MaSize);
            //    var d = _db.ChatLieus.FirstOrDefault(x => x.MaChatLieu == sp.MaChatLieu);
            //    var e = _db.ThuongHieus.FirstOrDefault(x => x.MaTh == sp.MaTh);
            //    sp.TenSanPham = item.
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
