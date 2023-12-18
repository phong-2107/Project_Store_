namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_MauXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_MauXe()
        {
            CT_GiaoHang = new HashSet<CT_GiaoHang>();
        }

        [Key]
        [StringLength(17)]
        public string SOKHUNG { get; set; }

        [Required]
        [StringLength(15)]
        public string SOMAY { get; set; }

        [Required]
        [StringLength(10)]
        public string IDMAUXE { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_NHAPHANG { get; set; }

        [Required]
        [StringLength(100)]
        public string CT_ANHXE { get; set; }

        [Required]
        [StringLength(50)]
        public string TINHTRANG { get; set; }

        [Required]
        [StringLength(10)]
        public string IDMAU { get; set; }

        [Required]
        [StringLength(5)]
        public string IDVITRI { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_GiaoHang> CT_GiaoHang { get; set; }

        public virtual MauSac MauSac { get; set; }

        public virtual PhieuNhapHang PhieuNhapHang { get; set; }
    }
}
