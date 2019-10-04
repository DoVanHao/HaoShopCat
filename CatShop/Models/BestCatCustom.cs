using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatShop.Models
{
    public class BestCatCustom
    {
        public string Id1 { get; set; }
        public int Check_cat { get; set; }
        public string Id { get; set; }

        public virtual Meo Meo { get; set; }
    }
}