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

    }
}
