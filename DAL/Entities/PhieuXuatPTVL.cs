namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuatPTVL")]
    public partial class PhieuXuatPTVL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuatPTVL()
        {
            CT_PXPTVL = new HashSet<CT_PXPTVL>();
        }

        [Key]
        [StringLength(10)]
        public string IDPX_PTVL { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PXPTVL> CT_PXPTVL { get; set; }

        public virtual HopDongDichVu HopDongDichVu { get; set; }
    }
}
