namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDoiTra")]
    public partial class PhieuDoiTra
    {
        [Key]
        [StringLength(10)]
        public string ID_DOITRA { get; set; }

        [Required]
        [StringLength(50)]
        public string TINHTRANG { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }

        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(10)]
        public string IDKH { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
