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
    public class QLNVRepos : IQLNVRepos
    {
        private MyContext _dbcontext;

        public QLNVRepos()
        {
            _dbcontext = new MyContext();
        }
        public bool AddNV(NhanVien nv)
        {
            _dbcontext.Add(nv);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAllNV()
        {
            return _dbcontext.NhanViens.ToList();
        }

        public bool RemoveNV(NhanVien nv)
        {
            _dbcontext.Remove(nv);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool UpdateNV(NhanVien nv)
        {
            _dbcontext.Update(nv);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetChucVus()
        {
            return _dbcontext.ChucVus.ToList();
        }

        public List<CaLamViec> GetCaLams()
        {
            return _dbcontext.CaLamViecs.ToList();
        }
    }
}