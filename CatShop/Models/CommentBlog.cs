namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommentBlog")]
    public partial class CommentBlog
    {
        [Key]
        [StringLength(20)]
        public string Ma_Comment { get; set; }

        [Required]
        [StringLength(200)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(500)]
        public string NoiDung { get; set; }

        public DateTime? ThoiGian { get; set; }

        [StringLength(20)]
        public string Ma_blog { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
