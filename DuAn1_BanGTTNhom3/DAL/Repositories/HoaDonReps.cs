using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
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
        public List<HoaDonChiTiet> GetHoaDonChiTiets()
        {
            return _connect.HoaDonChiTiets.ToList();
        }

        public List<HoaDon> GetHoaDons()
        {
            return _connect.HoaDons.ToList();
        }
    }
}
