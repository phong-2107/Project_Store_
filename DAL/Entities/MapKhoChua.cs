namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MapKhoChua")]
    public partial class MapKhoChua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MapKhoChua()
        {
            CT_MauXe = new HashSet<CT_MauXe>();
        }

        [Key]
        [StringLength(5)]
        public string IDVITRI { get; set; }

        public bool TRANGTHAI { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MauXe> CT_MauXe { get; set; }
    }
}
