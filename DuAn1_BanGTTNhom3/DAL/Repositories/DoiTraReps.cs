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
    public class DoiTraReps : IDoiTraReps
    {
        private MyContext _dbconnext;
        public DoiTraReps()
        {
            _dbconnext = new MyContext();
        }
        public bool CreateDoi(Doi doi)
        {
            if (GetDois().Count != 0)
            {
                var maxid = _dbconnext.Dois.Max(x => x.MaDoi);
                int nextid = Convert.ToInt32(maxid.Substring(3)) + 1;
                doi.MaDoi = "DOI" + nextid.ToString("D3");
            }
            else
            {
                doi.MaDoi = "DOI001";
            }
            _dbconnext.Dois.Add(doi);
            _dbconnext.SaveChanges();
            return true;
        }

        public bool CreateTra(Tra tra)
        {
            if (GetTras().Count != 0)
            {
                var maxid = _dbconnext.Dois.Max(x => x.MaDoi);
                int nextid = Convert.ToInt32(maxid.Substring(3)) + 1;
                tra.MaTra = "TRA" + nextid.ToString("D3");
            }
            else
            {
                tra.MaTra = "TRA001";
            }
            _dbconnext.Tras.Add(tra);
            _dbconnext.SaveChanges();
            return true;
        }

        public bool DeleteDoi(string id)
        {
            var results = _dbconnext.Dois.FirstOrDefault(x => x.MaDoi == id);
            if (results != null)
            {
                _dbconnext.Remove(results);
            }
            _dbconnext.SaveChanges();
            return true;
        }

        public bool DeleteTra(string id)
        {
            var results = _dbconnext.Tras.FirstOrDefault(x => x.MaTra == id);
            if (results != null)
            {
                _dbconnext.Remove(results);
            }
            _dbconnext.SaveChanges();
            return true;
        }

        public List<Doi> GetDois()
        {
            return _dbconnext.Dois.ToList();
        }

        public List<NhanVien> GetNhanViens()
        {
            return _dbconnext.NhanViens.ToList();
        }

        public List<SanPham> GetSanPhams()
        {
           return _dbconnext.SanPhams.ToList();
        }

        public List<Tra> GetTras()
        {
            return _dbconnext.Tras.ToList();
        }
    }
}
