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
        [Key]
        [StringLength(10)]
        public string IDVITRI { get; set; }
    }
}
