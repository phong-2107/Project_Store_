namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuatXe")]
    public partial class PhieuXuatXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuatXe()
        {
            CT_PPXE = new HashSet<CT_PPXE>();
        }

        [Key]
        [StringLength(10)]
        public string IDPX_XE { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHD { get; set; }

        public DateTime NGAYLAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PPXE> CT_PPXE { get; set; }

        public virtual HopDongDichVu HopDongDichVu { get; set; }
    }
}
