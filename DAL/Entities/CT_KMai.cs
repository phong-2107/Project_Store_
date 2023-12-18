namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KMai
    {
        [Key]
        [StringLength(10)]
        public string ID_TIEUCHI { get; set; }

        [Required]
        [StringLength(10)]
        public string IDKM { get; set; }

        [StringLength(10)]
        public string IDHSX { get; set; }

        [StringLength(10)]
        public string IDMAUXE { get; set; }

        [StringLength(10)]
        public string IDHANG { get; set; }

        public int? SLMUA { get; set; }

        public DateTime? NGAYMUA { get; set; }

        public virtual HangSX HangSX { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }

        public virtual MauXe MauXe { get; set; }

        public virtual PhuTung_VatLieu PhuTung_VatLieu { get; set; }
    }
}
