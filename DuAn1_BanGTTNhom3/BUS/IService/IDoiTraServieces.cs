using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IDoiTraServieces
    {
        public List<Doi> GetDois(string find);
        public List<Tra> GetTras(string find);
        public List<NhanVien> GetNhanViens();
        public List<SanPham> GetSanPhams();
        public bool CreateDoi(Doi doi);
        public bool CreateTra(Tra tra);
        public bool DeleteTra(string id);
        public bool DeleteDoi(string id);
        public string UpdateTras(Tra tra);
    }
}
