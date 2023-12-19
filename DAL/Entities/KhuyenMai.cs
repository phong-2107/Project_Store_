namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhuyenMai()
        {
            CT_KMai = new HashSet<CT_KMai>();
            HopDongDichVus = new HashSet<HopDongDichVu>();
            PhieuThanhToans = new HashSet<PhieuThanhToan>();
        }

        [Key]
        [StringLength(10)]
        public string IDKM { get; set; }

        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(100)]
        public string NOIDUNGKM { get; set; }

        public int GTRI_KM { get; set; }

        public DateTime KM_START { get; set; }

        public DateTime KM_END { get; set; }

        [StringLength(50)]
        public string NOTE { get; set; }

        [Required]
        [StringLength(10)]
        public string ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KMai> CT_KMai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDongDichVu> HopDongDichVus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThanhToan> PhieuThanhToans { get; set; }
    }
}
