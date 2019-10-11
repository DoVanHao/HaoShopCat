namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LastNew")]
    public partial class LastNew
    {
        [Key]
        [StringLength(20)]
        public string Id1 { get; set; }

        [StringLength(500)]
        public string News { get; set; }

        public int Check_cat { get; set; }

        [Required]
        [StringLength(20)]
        public string Id { get; set; }

        public virtual Meo Meo { get; set; }
    }
}
