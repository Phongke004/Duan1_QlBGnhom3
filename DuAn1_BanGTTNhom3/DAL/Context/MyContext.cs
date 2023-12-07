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

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

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
            entity.HasKey(e => e.MaCa).HasName("PK__CaLamVie__27258E7BC6410A31");
        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {
            entity.HasKey(e => e.MaChatLieu).HasName("PK__ChatLieu__453995BC5C33ACE7");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E76AA97A469");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.HasKey(e => e.MaCoupon).HasName("PK__Coupon__44DC861CF497941C");
        });

        modelBuilder.Entity<Doi>(entity =>
        {
            entity.HasKey(e => e.MaDoi).HasName("PK__Doi__3D89F55300DF55B1");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Dois).HasConstraintName("FK__Doi__MaHDCT__67DE6983");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0628F0F36");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaKH__61316BF4");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaNV__603D47BB");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaSp__5F492382");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHdct).HasName("PK__HoaDonCh__1419C1297DE0803C");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaHD__6501FCD8");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__MaVou__640DD89F");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1E39118DFB");

            entity.HasOne(d => d.MaRankNavigation).WithMany(p => p.KhachHangs).HasConstraintName("FK__KhachHang__MaRan__5C6CB6D7");
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.MaMau).HasName("PK__MauSac__3A5BBB7D6B3EF113");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70AA489AB50");

            entity.HasOne(d => d.MaCaNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaCa__467D75B8");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaChuc__4589517F");
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity.HasKey(e => e.MaRank).HasName("PK__RANKS__7AE11877165B17AE");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C4444934A");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaChatL__52E34C9D");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaMau__50FB042B");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaSize__51EF2864");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaTH__53D770D6");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.MaSize).HasName("PK__Size__A787E7EDEDDEDF17");
        });

        modelBuilder.Entity<Thongke>(entity =>
        {
            entity.HasKey(e => e.MaThongKe).HasName("PK__THONGKE__60E521F457F9F91D");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaHD__6D9742D9");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaNv__6E8B6712");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.MaTh).HasName("PK__ThuongHi__27250075CB94F910");
        });

        modelBuilder.Entity<Tra>(entity =>
        {
            entity.HasKey(e => e.MaTra).HasName("PK__Tra__31493C676D0AA078");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Tras).HasConstraintName("FK__Tra__MaHDCT__6ABAD62E");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B1194C30E77");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
