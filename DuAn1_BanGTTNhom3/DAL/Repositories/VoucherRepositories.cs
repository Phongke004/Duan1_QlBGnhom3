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
    public class VoucherRepositories : IVoucherRepositories
    {
        private MyContext _db;
        public VoucherRepositories()
        {
            _db = new MyContext();
        }

        public bool Add(Voucher vc)
        {
            if (GetVC().Count != 0)
            {
                var maxid = _db.Vouchers.Max(x => x.MaVoucher);
                int nextid = Convert.ToInt32(maxid.Substring(2)) + 1;
                vc.MaVoucher = "VC" + nextid.ToString("D3");
            }
            else
            {
                vc.MaVoucher = "VC001";
            }
            _db.Add(vc);
            _db.SaveChanges();
            return true;
        }
        public List<Voucher> GetVC()
        {
            return _db.Vouchers.ToList();
        }

        public bool Update(Voucher vc)
        {
            try
            {
                if (vc == null) return false;
                var e = _db.Vouchers.FirstOrDefault(x => x.MaVoucher == vc.MaVoucher);
                if (e == null) return false;
                e.TenVoucher = vc.TenVoucher;
                e.GiaTri = vc.GiaTri;
                e.MoTa = vc.MoTa;
                e.DieuKien = vc.DieuKien;
                e.NgayBatDau =vc.NgayBatDau;
                e.NgayKetThuc = vc.NgayKetThuc;
                _db.Vouchers.Update(e);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
