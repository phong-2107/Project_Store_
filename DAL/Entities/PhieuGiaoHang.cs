namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuGiaoHang")]
    public partial class PhieuGiaoHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuGiaoHang()
        {
            CT_GiaoHang = new HashSet<CT_GiaoHang>();
        }

        [Key]
        [StringLength(10)]
        public string ID_GIAOHANG { get; set; }

        public DateTime NGAYGIAO { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHD { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        public virtual HopDongDichVu HopDongDichVu { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_GiaoHang> CT_GiaoHang { get; set; }
    }
}
