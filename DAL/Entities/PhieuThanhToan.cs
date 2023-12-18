namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThanhToan")]
    public partial class PhieuThanhToan
    {
        [Key]
        [StringLength(10)]
        public string ID_THANHTOAN { get; set; }

        [Required]
        [StringLength(20)]
        public string PPTHANHTOAN { get; set; }

        [Required]
        [StringLength(10)]
        public string IDKM { get; set; }

        public decimal TONGGT { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHD { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }
    }
}
