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

            entity.HasKey(e => e.MaCa).HasName("PK__CaLamVie__27258E7B583358C9");

        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {

            entity.HasKey(e => e.MaChatLieu).HasName("PK__ChatLieu__453995BCCF531B33");

        });

        modelBuilder.Entity<ChucVu>(entity =>
        {

            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E76BBA8F851");

        });

        modelBuilder.Entity<Coupon>(entity =>
        {

            entity.HasKey(e => e.MaCoupon).HasName("PK__Coupon__44DC861C52FB58D2");

        });

        modelBuilder.Entity<Doi>(entity =>
        {

            entity.HasKey(e => e.MaDoi).HasName("PK__Doi__3D89F553708B5AB6");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Dois).HasConstraintName("FK__Doi__MaHDCT__0880433F");

        });

        modelBuilder.Entity<HoaDon>(entity =>
        {

            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0FD58137F");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaKH__02C769E9");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaNV__01D345B0");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaSp__7FEAFD3E");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaVouche__00DF2177");

        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {

            entity.HasKey(e => e.MaHdct).HasName("PK__HoaDonCh__1419C129CBA1BDA9");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaHD__05A3D694");

        });

        modelBuilder.Entity<KhachHang>(entity =>
        {

            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1EA80F8131");

            entity.HasOne(d => d.MaRankNavigation).WithMany(p => p.KhachHangs).HasConstraintName("FK__KhachHang__MaRan__7D0E9093");

        });

        modelBuilder.Entity<MauSac>(entity =>
        {

            entity.HasKey(e => e.MaMau).HasName("PK__MauSac__3A5BBB7D37FB0A74");

        });

        modelBuilder.Entity<NhanVien>(entity =>
        {

            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70AA173570F");

            entity.HasOne(d => d.MaCaNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaCa__671F4F74");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaChuc__662B2B3B");

        });

        modelBuilder.Entity<Rank>(entity =>
        {

            entity.HasKey(e => e.MaRank).HasName("PK__RANKS__7AE11877EECC0FEA");

        });

        modelBuilder.Entity<SanPham>(entity =>
        {

            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C096B9BE9");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaChatL__73852659");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaMau__719CDDE7");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaSize__72910220");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaTH__74794A92");

        });

        modelBuilder.Entity<Size>(entity =>
        {

            entity.HasKey(e => e.MaSize).HasName("PK__Size__A787E7ED58A0056F");

        });

        modelBuilder.Entity<Thongke>(entity =>
        {

            entity.HasKey(e => e.MaThongKe).HasName("PK__THONGKE__60E521F407C2906B");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaHD__0E391C95");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaNv__0F2D40CE");

        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {

            entity.HasKey(e => e.MaTh).HasName("PK__ThuongHi__27250075F04D8C95");

        });

        modelBuilder.Entity<Tra>(entity =>
        {

            entity.HasKey(e => e.MaTra).HasName("PK__Tra__31493C67C2AB20B3");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Tras).HasConstraintName("FK__Tra__MaHDCT__0B5CAFEA");

        });

        modelBuilder.Entity<Voucher>(entity =>
        {

            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B111FAA9CFC");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
