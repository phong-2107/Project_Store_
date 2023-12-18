namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_GiaoHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID_GIAOHANG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(17)]
        public string SOKHUNG { get; set; }

        [StringLength(50)]
        public string NOTE { get; set; }

        public virtual CT_MauXe CT_MauXe { get; set; }

        public virtual PhieuGiaoHang PhieuGiaoHang { get; set; }
    }
}
