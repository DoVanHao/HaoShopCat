namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Login")]
    public partial class C_Login
    {
        [Key]
        [StringLength(20)]
        public string Ma_NguoiDung { get; set; }

        [Required]
        [StringLength(100)]
        public string TaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
    }
}
