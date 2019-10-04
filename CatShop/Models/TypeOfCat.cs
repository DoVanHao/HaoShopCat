using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatShop.Models
{
    public class TypeOfCat
    {
        public string Ma_Loai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<Meo> Meos { get; set; }

    }
}