namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauSac")]
    public partial class MauSac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MauSac()
        {
            CT_MauXe = new HashSet<CT_MauXe>();
        }

        [Key]
        [StringLength(10)]
        public string IDMAU { get; set; }

        [Required]
        [StringLength(20)]
        public string TENMAU { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MauXe> CT_MauXe { get; set; }
    }
}
