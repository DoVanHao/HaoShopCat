namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Meo")]
    public partial class Meo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meo()
        {
            BestCats = new HashSet<BestCat>();
            LastNews = new HashSet<LastNew>();
            MaxMonneyCats = new HashSet<MaxMonneyCat>();
            SellerCats = new HashSet<SellerCat>();
        }

        [StringLength(20)]
        public string Id { get; set; }

        [Required]
        [StringLength(200)]
        public string MauSac { get; set; }

        [StringLength(500)]
        public string DacDiemNoiBat { get; set; }

        public double? CanNang { get; set; }

        public int? Ngaytuoi { get; set; }

        [StringLength(200)]
        public string GiaBan { get; set; }

        [Required]
        [StringLength(200)]
        public string img { get; set; }

        [Required]
        [StringLength(20)]
        public string Ma_Loai { get; set; }

        [Required]
        [StringLength(20)]
        public string Ma_PerSon { get; set; }

        public int? luot_like { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BestCat> BestCats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LastNew> LastNews { get; set; }

        public virtual LoaiMeo LoaiMeo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaxMonneyCat> MaxMonneyCats { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SellerCat> SellerCats { get; set; }
    }
}
