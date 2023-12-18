namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanLogin")]
    public partial class TaiKhoanLogin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoanLogin()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [StringLength(20)]
        public string TENTAIKHOAN { get; set; }

        [Required]
        [StringLength(20)]
        public string MATKHAU { get; set; }

        public int QUYENHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
