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
            entity.HasKey(e => e.MaCa).HasName("PK__CaLamVie__27258E7BE6C1044F");
        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {
            entity.HasKey(e => e.MaChatLieu).HasName("PK__ChatLieu__453995BCF72F478F");
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.Maspct).HasName("PK__ChiTietS__3D158D86223514D1");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaCha__43D61337");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaMau__41EDCAC5");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaSiz__42E1EEFE");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSan__MaSP__40F9A68C");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSan__MaTH__44CA3770");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E762CE5CFC4");
        });

        modelBuilder.Entity<Doi>(entity =>
        {
            entity.HasKey(e => e.MaDoi).HasName("PK__Doi__3D89F553BEB9D557");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Dois).HasConstraintName("FK__Doi__MaHDCT__56E8E7AB");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0A62EF1FF");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaKH__51300E55");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaNV__503BEA1C");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaSp__4E53A1AA");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaVouche__4F47C5E3");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHdct).HasName("PK__HoaDonCh__1419C129DD0C8885");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaHD__540C7B00");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1ED311B778");
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.MaMau).HasName("PK__MauSac__3A5BBB7D476E7B56");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70A39097FB3");

            entity.HasOne(d => d.MaCaNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaCa__3493CFA7");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaChuc__339FAB6E");
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity.HasKey(e => e.MaRank).HasName("PK__RANKS__7AE11877A18306F7");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Ranks).HasConstraintName("FK__RANKS__MaKH__4B7734FF");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081CBCC06F38");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.MaSize).HasName("PK__Size__A787E7EDAB87E18A");
        });

        modelBuilder.Entity<Thongke>(entity =>
        {
            entity.HasKey(e => e.MaThongKe).HasName("PK__THONGKE__60E521F40BF6C57D");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaHD__5CA1C101");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaNv__5D95E53A");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.MaTh).HasName("PK__ThuongHi__2725007537C1746D");
        });

        modelBuilder.Entity<Tra>(entity =>
        {
            entity.HasKey(e => e.MaTra).HasName("PK__Tra__31493C67BBB177B3");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Tras).HasConstraintName("FK__Tra__MaHDCT__59C55456");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B1198A4D2EB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
