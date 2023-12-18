namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuBaoHanh")]
    public partial class PhieuBaoHanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuBaoHanh()
        {
            CT_BaoHanh = new HashSet<CT_BaoHanh>();
        }

        [Key]
        [StringLength(10)]
        public string ID_BAOHANH { get; set; }

        [Column(TypeName = "date")]
        public DateTime BHSTART { get; set; }

        [Column(TypeName = "date")]
        public DateTime BHEND { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHD { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BaoHanh> CT_BaoHanh { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
