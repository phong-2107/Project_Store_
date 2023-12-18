namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhapHang")]
    public partial class PhieuNhapHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhapHang()
        {
            CT_MauXe = new HashSet<CT_MauXe>();
            CT_PNhapPTVL = new HashSet<CT_PNhapPTVL>();
            CT_PNhapXe = new HashSet<CT_PNhapXe>();
        }

        [Key]
        [StringLength(10)]
        public string ID_NHAPHANG { get; set; }

        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        [StringLength(10)]
        public string IDNCC { get; set; }

        public decimal? TONGHOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MauXe> CT_MauXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNhapPTVL> CT_PNhapPTVL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNhapXe> CT_PNhapXe { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
