namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_BaoHanh
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime NGAYBH { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_BAOHANH { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHD { get; set; }

        public int SODOT { get; set; }

        [Required]
        [StringLength(100)]
        public string TINHTRANGBH { get; set; }

        public virtual HopDongDichVu HopDongDichVu { get; set; }

        public virtual PhieuBaoHanh PhieuBaoHanh { get; set; }
    }
}
