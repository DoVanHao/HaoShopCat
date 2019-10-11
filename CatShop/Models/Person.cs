namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Meos = new HashSet<Meo>();
        }

        [Key]
        [StringLength(20)]
        public string Ma_PerSon { get; set; }

        [Required]
        [StringLength(200)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meo> Meos { get; set; }
    }
}
