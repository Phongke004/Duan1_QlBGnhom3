using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("RANKS")]
public partial class Rank
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaRank { get; set; } = null!;

    [StringLength(100)]
    public string? DieuKien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MucUuDai { get; set; }

    [StringLength(30)]
    public string? TrangThai { get; set; }

    [StringLength(250)]
    public string? MoTa { get; set; }

    [Column("MaKH")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaKh { get; set; }

    [ForeignKey("MaKh")]
    [InverseProperty("Ranks")]
    public virtual KhachHang? MaKhNavigation { get; set; }
}
