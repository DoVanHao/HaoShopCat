namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiMeo")]
    public partial class LoaiMeo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiMeo()
        {
            Meos = new HashSet<Meo>();
        }

        [Key]
        [StringLength(20)]
        public string Ma_Loai { get; set; }

        [Required]
        [StringLength(200)]
        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meo> Meos { get; set; }
    }
}
