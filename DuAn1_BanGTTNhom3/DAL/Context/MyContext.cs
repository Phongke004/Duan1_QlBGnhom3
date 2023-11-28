using System;
using System.Collections.Generic;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CaLamViec> CaLamViecs { get; set; }

    public virtual DbSet<ChatLieu> ChatLieus { get; set; }

    public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<Doi> Dois { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<MauSac> MauSacs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Rank> Ranks { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Thongke> Thongkes { get; set; }

    public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }

    public virtual DbSet<Tra> Tras { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

        => optionsBuilder.UseSqlServer("Data Source=PHONGKEDAY2\\PHONGKE2004;Initial Catalog=QLBanGiayTheThao_DuAn1;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaLamViec>(entity =>
        {
            entity.HasKey(e => e.IdCaLamViec).HasName("PK__CaLamVie__A8F5E8B5EDE1C297");

            entity.Property(e => e.IdCaLamViec).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {
            entity.HasKey(e => e.IdChatlieu).HasName("PK__ChatLieu__942B70D5D1D67C1B");

            entity.Property(e => e.IdChatlieu).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.IdChiTietSp).HasName("PK__ChiTietS__C95E75E558C465B3");

            entity.Property(e => e.IdChiTietSp).ValueGeneratedNever();

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaCha__4BAC3F29");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaMau__49C3F6B7");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaSiz__4AB81AF0");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSan__MaSP__48CFD27E");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSan__MaTH__4CA06362");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.IdChucVu).HasName("PK__ChucVu__2765C9B505B3256E");

            entity.Property(e => e.IdChucVu).ValueGeneratedNever();
        });

        modelBuilder.Entity<Doi>(entity =>
        {
            entity.HasKey(e => e.IdDoi).HasName("PK__Doi__3E411440ACCE5843");

            entity.Property(e => e.IdDoi).ValueGeneratedNever();

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Dois).HasConstraintName("FK__Doi__MaHDCT__5EBF139D");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.IdHoaDon).HasName("PK__HoaDon__B060C52C3C7EF118");

            entity.Property(e => e.IdHoaDon).ValueGeneratedNever();

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaKh__59063A47");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaNV__5812160E");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaSp__5629CD9C");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaVouche__571DF1D5");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdHoaDonCt).HasName("PK__HoaDonCh__4C84ED36570A1182");

            entity.Property(e => e.IdHoaDonCt).ValueGeneratedNever();

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaHD__5BE2A6F2");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdKhachHang).HasName("PK__KhachHan__DAF646D0FAA52CE0");

            entity.Property(e => e.IdKhachHang).ValueGeneratedNever();
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.IdMauSac).HasName("PK__MauSac__C663C921223CFF70");

            entity.Property(e => e.IdMauSac).ValueGeneratedNever();
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdNhanVien).HasName("PK__NhanVien__214E82586A27D9D3");

            entity.Property(e => e.IdNhanVien).ValueGeneratedNever();

            entity.HasOne(d => d.MaCaNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaCa__3C69FB99");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaChuc__3B75D760");
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity.HasKey(e => e.RankId).HasName("PK__RANKS__B37AFB96198C6036");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Ranks).HasConstraintName("FK__RANKS__MaKh__534D60F1");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.IdSanPham).HasName("PK__SanPham__B58D5DAC07A51884");

            entity.Property(e => e.IdSanPham).ValueGeneratedNever();
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.IdSize).HasName("PK__Size__C69FA05BD424A4F6");

            entity.Property(e => e.IdSize).ValueGeneratedNever();
        });

        modelBuilder.Entity<Thongke>(entity =>
        {
            entity.HasKey(e => e.IdThongKe).HasName("PK__THONGKE__08113CFE46A460EC");

            entity.Property(e => e.IdThongKe).ValueGeneratedNever();

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaHD__6477ECF3");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaNv__656C112C");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.IdThuongHieu).HasName("PK__ThuongHi__909F29FC60DBBB0D");

            entity.Property(e => e.IdThuongHieu).ValueGeneratedNever();
        });

        modelBuilder.Entity<Tra>(entity =>
        {
            entity.HasKey(e => e.IdTra).HasName("PK__Tra__020F1387DD1BEFB9");

            entity.Property(e => e.IdTra).ValueGeneratedNever();

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Tras).HasConstraintName("FK__Tra__MaHDCT__619B8048");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.IdVouCher).HasName("PK__Voucher__BA9ED7CB167C8E6E");

            entity.Property(e => e.IdVouCher).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
