namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDongDichVu")]
    public partial class HopDongDichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HopDongDichVu()
        {
            CT_BaoHanh = new HashSet<CT_BaoHanh>();
            PhieuGiaoHangs = new HashSet<PhieuGiaoHang>();
            PhieuHens = new HashSet<PhieuHen>();
            PhieuXuatPTVLs = new HashSet<PhieuXuatPTVL>();
            PhieuXuatXes = new HashSet<PhieuXuatXe>();
        }

        [Key]
        [StringLength(10)]
        public string IDHD { get; set; }

        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        [Required]
        [StringLength(10)]
        public string IDKH { get; set; }

        [StringLength(50)]
        public string NOTE { get; set; }

        public decimal? TONGGT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BaoHanh> CT_BaoHanh { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuGiaoHang> PhieuGiaoHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuHen> PhieuHens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatPTVL> PhieuXuatPTVLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatXe> PhieuXuatXes { get; set; }
    }
}
