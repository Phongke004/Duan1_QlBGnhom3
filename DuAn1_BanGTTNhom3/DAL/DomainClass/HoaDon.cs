using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("HoaDon")]
public partial class HoaDon
{
    [Key]
    [Column("MaHD")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaHd { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? NgayTao { get; set; }

    [StringLength(30)]
    public string? TrangThai { get; set; }

    public double? TongTien { get; set; }

    public double? TongTienSauVoucher { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaSp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaVoucher { get; set; }

    [Column("MaNV")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaNv { get; set; }

    [Column("MaKH")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaKh { get; set; }

    [InverseProperty("MaHdNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("MaKh")]
    [InverseProperty("HoaDons")]
    public virtual KhachHang? MaKhNavigation { get; set; }

    [ForeignKey("MaNv")]
    [InverseProperty("HoaDons")]
    public virtual NhanVien? MaNvNavigation { get; set; }

    [ForeignKey("MaSp")]
    [InverseProperty("HoaDons")]
    public virtual SanPham? MaSpNavigation { get; set; }

    [ForeignKey("MaVoucher")]
    [InverseProperty("HoaDons")]
    public virtual Voucher? MaVoucherNavigation { get; set; }

    [InverseProperty("MaHdNavigation")]
    public virtual ICollection<Thongke> Thongkes { get; set; } = new List<Thongke>();
}
