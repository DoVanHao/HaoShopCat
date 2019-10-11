namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Blog")]
    public partial class Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog()
        {
            CommentBlogs = new HashSet<CommentBlog>();
        }

        [Key]
        [StringLength(20)]
        public string Ma_blog { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string NoiDung { get; set; }

        [Required]
        [StringLength(200)]
        public string img { get; set; }

        public DateTime? ThoiGian { get; set; }

        public int? slview { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentBlog> CommentBlogs { get; set; }
    }
}
