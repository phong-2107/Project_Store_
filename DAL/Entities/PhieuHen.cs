namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuHen")]
    public partial class PhieuHen
    {
        [Key]
        [StringLength(10)]
        public string ID_HEN { get; set; }

        public DateTime NGAYLAP { get; set; }

        public DateTime NGAYHEN { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHD { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }

        public virtual HopDongDichVu HopDongDichVu { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
