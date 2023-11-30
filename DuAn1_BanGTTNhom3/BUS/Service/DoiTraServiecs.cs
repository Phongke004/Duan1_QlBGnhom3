using BUS.IService;
using DAL.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class DoiTraServiecs : IDoiTraServieces
    {
        DoiTraReps _doiTraReps;
        public DoiTraServiecs()
        {
            _doiTraReps = new DoiTraReps();
        }

        public bool CreateDoi(Doi doi)
        {
            if (_doiTraReps.CreateDoi(doi))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CreateTra(Tra tra)
        {
            if (_doiTraReps.CreateTra(tra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDoi(string id)
        {
            if (_doiTraReps.DeleteDoi(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteTra(string id)
        {
            if (_doiTraReps.DeleteTra(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Doi> GetDois(string find)
        {
            if (find == null)
            {
                return _doiTraReps.GetDois();
            }
            return _doiTraReps.GetDois().Where(x => x.MaDoi.Contains(find.Trim().ToLower())).ToList();
        }

        public List<NhanVien> GetNhanViens()
        {
            return _doiTraReps.GetNhanViens();
        }

        public List<SanPham> GetSanPhams()
        {
           return _doiTraReps.GetSanPhams();
        }

        public List<Tra> GetTras(string find)
        {
            if (find == null)
            {
                return _doiTraReps.GetTras();
            }
            return _doiTraReps.GetTras().Where(x => x.MaTra.Contains(find.Trim().ToLower())).ToList();
        }

    }
}
