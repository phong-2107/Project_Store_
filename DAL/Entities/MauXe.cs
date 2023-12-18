namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauXe")]
    public partial class MauXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MauXe()
        {
            CT_KMai = new HashSet<CT_KMai>();
            CT_PNhapXe = new HashSet<CT_PNhapXe>();
            CT_PPXE = new HashSet<CT_PPXE>();
        }

        [Key]
        [StringLength(10)]
        public string IDMAUXE { get; set; }

        [Required]
        [StringLength(50)]
        public string TENMAUXE { get; set; }

        public int PHANKHOI { get; set; }

        [Required]
        [StringLength(20)]
        public string LOAICON { get; set; }

        public decimal GIANHAP { get; set; }

        public decimal GIABAN { get; set; }

        public int SOLUONG { get; set; }

        public string ANHTQ { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNCC { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHANGSX { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KMai> CT_KMai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNhapXe> CT_PNhapXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PPXE> CT_PPXE { get; set; }

        public virtual HangSX HangSX { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
