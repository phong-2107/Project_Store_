namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PhuTung_VatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhuTung_VatLieu()
        {
            CT_PNhapPTVL = new HashSet<CT_PNhapPTVL>();
            CT_PXPTVL = new HashSet<CT_PXPTVL>();
        }

        [Key]
        [StringLength(10)]
        public string IDHANG { get; set; }

        public bool ID_LOAIHANG { get; set; }

        [Required]
        [StringLength(30)]
        public string TENHANG { get; set; }

        public int SOLUONG { get; set; }

        [StringLength(100)]
        public string CHUTHICH { get; set; }

        public decimal GIANHAP { get; set; }

        public decimal GIABAN { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNCC { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHANGSX { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNhapPTVL> CT_PNhapPTVL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PXPTVL> CT_PXPTVL { get; set; }

        public virtual HangSX HangSX { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
