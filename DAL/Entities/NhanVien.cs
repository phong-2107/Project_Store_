namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HopDongDichVus = new HashSet<HopDongDichVu>();
            PhieuBaoHanhs = new HashSet<PhieuBaoHanh>();
            PhieuDoiTras = new HashSet<PhieuDoiTra>();
            PhieuGiaoHangs = new HashSet<PhieuGiaoHang>();
            PhieuHens = new HashSet<PhieuHen>();
            PhieuNhapHangs = new HashSet<PhieuNhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string IDNV { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNV { get; set; }

        [Required]
        [StringLength(9)]
        public string NAMSINH { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        [Required]
        [StringLength(30)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(100)]
        public string ANHNV { get; set; }

        [Required]
        [StringLength(12)]
        public string IDCCCD { get; set; }

        [Required]
        [StringLength(9)]
        public string NGAYGN { get; set; }

        [Required]
        [StringLength(20)]
        public string TENTAIKHOAN { get; set; }

        public bool GIOITINH { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDongDichVu> HopDongDichVus { get; set; }

        public virtual TaiKhoanLogin TaiKhoanLogin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDoiTra> PhieuDoiTras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuGiaoHang> PhieuGiaoHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuHen> PhieuHens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; }
    }
}
