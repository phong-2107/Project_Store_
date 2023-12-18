namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            MauXes = new HashSet<MauXe>();
            PhieuNhapHangs = new HashSet<PhieuNhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string IDNCC { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNCC { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        [Required]
        [StringLength(100)]
        public string LOGO { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MauXe> MauXes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; }
    }
}
