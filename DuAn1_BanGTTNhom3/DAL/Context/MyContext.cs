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

        => optionsBuilder.UseSqlServer("Data Source=VANNTRONGG\\SQLEXPRESS;Initial Catalog=QLBanGiayTheThao_DuAn1;Integrated Security=True;TrustServerCertificate=true");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaLamViec>(entity =>
        {

            entity.HasKey(e => e.MaCa).HasName("PK__CaLamVie__27258E7B7A5C8833");

        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {

            entity.HasKey(e => e.MaChatLieu).HasName("PK__ChatLieu__453995BC3A79DEBC");

        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {

            entity.HasKey(e => e.Maspct).HasName("PK__ChiTietS__3D158D8693A201A4");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaCha__3F115E1A");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaMau__3D2915A8");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaSiz__3E1D39E1");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSan__MaSP__3C34F16F");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSan__MaTH__40058253");

        });

        modelBuilder.Entity<ChucVu>(entity =>
        {

            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E766F53B05F");

        });

        modelBuilder.Entity<Doi>(entity =>
        {

            entity.HasKey(e => e.MaDoi).HasName("PK__Doi__3D89F553E0C3E7CB");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Dois).HasConstraintName("FK__Doi__MaHDCT__5224328E");

        });

        modelBuilder.Entity<HoaDon>(entity =>
        {

            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0D38457D0");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaKH__4C6B5938");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaNV__4B7734FF");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaSp__498EEC8D");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaVouche__4A8310C6");

        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {

            entity.HasKey(e => e.MaHdct).HasName("PK__HoaDonCh__1419C129C27377A7");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaHD__4F47C5E3");

        });

        modelBuilder.Entity<KhachHang>(entity =>
        {

            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1E76B3B901");

        });

        modelBuilder.Entity<MauSac>(entity =>
        {

            entity.HasKey(e => e.MaMau).HasName("PK__MauSac__3A5BBB7D23AA0A6C");

        });

        modelBuilder.Entity<NhanVien>(entity =>
        {

            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70A3961B91F");

            entity.HasOne(d => d.MaCaNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaCa__2FCF1A8A");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaChuc__2EDAF651");

        });

        modelBuilder.Entity<Rank>(entity =>
        {

            entity.HasKey(e => e.MaRank).HasName("PK__RANKS__7AE1187715E1F9C2");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Ranks).HasConstraintName("FK__RANKS__MaKH__46B27FE2");

        });

        modelBuilder.Entity<SanPham>(entity =>
        {

            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C6A2F6333");

        });

        modelBuilder.Entity<Size>(entity =>
        {

            entity.HasKey(e => e.MaSize).HasName("PK__Size__A787E7ED07855B95");

        });

        modelBuilder.Entity<Thongke>(entity =>
        {

            entity.HasKey(e => e.MaThongKe).HasName("PK__THONGKE__60E521F4B4188C51");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaHD__57DD0BE4");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaNv__58D1301D");

        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {

            entity.HasKey(e => e.MaTh).HasName("PK__ThuongHi__2725007586725F62");

        });

        modelBuilder.Entity<Tra>(entity =>
        {

            entity.HasKey(e => e.MaTra).HasName("PK__Tra__31493C672EE5D66C");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Tras).HasConstraintName("FK__Tra__MaHDCT__55009F39");

        });

        modelBuilder.Entity<Voucher>(entity =>
        {

            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B11F0EC26A5");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
