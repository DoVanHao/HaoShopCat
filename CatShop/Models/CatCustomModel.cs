using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatShop.Models
{
    public class CatCustomModel
    {
        public string Id { get; set; }
        public string MauSac { get; set; }
        public string DacDiemNoiBat { get; set; }
        public Nullable<double> CanNang { get; set; }
        public Nullable<int> Ngaytuoi { get; set; }
        public string GiaBan { get; set; }
        public string img { get; set; }
        public string Ma_Loai { get; set; }
        public string Ma_PerSon { get; set; }
        public string TenLoaiMeo { get; set; }
        public string giamoi { get; set; }
        public int luot_like { get; set; }
        public virtual LoaiMeo LoaiMeo { get; set; }
        public virtual Person Person { get; set; }
    }
}