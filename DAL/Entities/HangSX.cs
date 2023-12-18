namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangSX")]
    public partial class HangSX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangSX()
        {
            CT_KMai = new HashSet<CT_KMai>();
            MauXes = new HashSet<MauXe>();
            PhuTung_VatLieu = new HashSet<PhuTung_VatLieu>();
        }

        [Key]
        [StringLength(10)]
        public string IDHANGSX { get; set; }

        [Required]
        [StringLength(50)]
        public string TENHSX { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGO { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KMai> CT_KMai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MauXe> MauXes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhuTung_VatLieu> PhuTung_VatLieu { get; set; }
    }
}
