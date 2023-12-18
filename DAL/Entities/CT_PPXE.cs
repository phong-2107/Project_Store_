namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PPXE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDPX_XE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDMAUXE { get; set; }

        public int SOLUONG { get; set; }

        public virtual MauXe MauXe { get; set; }

        public virtual PhieuXuatXe PhieuXuatXe { get; set; }
    }
}
