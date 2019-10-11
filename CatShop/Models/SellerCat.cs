namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SellerCat")]
    public partial class SellerCat
    {
        [Key]
        [StringLength(20)]
        public string Id1 { get; set; }

        public int? TiLeGiam { get; set; }

        public int Check_cat { get; set; }

        [Required]
        [StringLength(20)]
        public string Id { get; set; }

        public virtual Meo Meo { get; set; }
    }
}
