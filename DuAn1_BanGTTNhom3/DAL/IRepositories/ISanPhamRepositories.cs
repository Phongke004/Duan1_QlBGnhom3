﻿using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ISanPhamRepositories
    {
        public bool Add(SanPham sp);
        public bool Update(SanPham sp);
        public List<SanPham> GetAll();
        
        public List<HoaDon> GetHoaDon();
        public List<MauSac> GetMauSac();
        public List<Size> GetSize();
        public List<ChatLieu> GetChatLieu();
        public List<ThuongHieu> GetThuongHieu();
    }
}
