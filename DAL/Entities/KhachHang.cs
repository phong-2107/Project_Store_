namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HopDongDichVus = new HashSet<HopDongDichVu>();
            PhieuDoiTras = new HashSet<PhieuDoiTra>();
        }

        [Key]
        [StringLength(10)]
        public string IDKH { get; set; }

        [StringLength(30)]
        public string TENKH { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(12)]
        public string IDCCCD { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDongDichVu> HopDongDichVus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDoiTra> PhieuDoiTras { get; set; }
    }
}
