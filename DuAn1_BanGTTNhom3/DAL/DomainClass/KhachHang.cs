﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("KhachHang")]
public partial class KhachHang
{
    [Key]
    [Column("MaKH")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaKh { get; set; } = null!;

    [Column("SDT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    public double? Diem { get; set; }

    [InverseProperty("MaKhNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    [InverseProperty("MaKhNavigation")]
    public virtual ICollection<Rank> Ranks { get; set; } = new List<Rank>();
}
