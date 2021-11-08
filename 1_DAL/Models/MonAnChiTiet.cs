﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("MonAnChiTiet")]
    public partial class MonAnChiTiet
    {
        [Key]
        public int MaMon { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("IDUnit")]
        public int Idunit { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column("IDCategory")]
        public int Idcategory { get; set; }
        [Column("IDMethod")]
        public int Idmethod { get; set; }
        public int? Status { get; set; }
        [StringLength(500)]
        public string Anh { get; set; }

        [ForeignKey(nameof(Idcategory))]
        [InverseProperty(nameof(DanhMucFood.MonAnChiTiets))]
        public virtual DanhMucFood IdcategoryNavigation { get; set; }
        [ForeignKey(nameof(Idunit))]
        [InverseProperty(nameof(HoaDonChiTiet.MonAnChiTiets))]
        public virtual HoaDonChiTiet Idunit1 { get; set; }
        [ForeignKey(nameof(Idunit))]
        [InverseProperty(nameof(DonVi.MonAnChiTiets))]
        public virtual DonVi IdunitNavigation { get; set; }
        [ForeignKey(nameof(MaMon))]
        [InverseProperty(nameof(ThucDon.MonAnChiTiet))]
        public virtual ThucDon MaMonNavigation { get; set; }
    }
}
