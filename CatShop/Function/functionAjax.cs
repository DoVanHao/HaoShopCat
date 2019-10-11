using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatShop.Models;
using System.Linq;
namespace CatShop.Function
{
    public class functionAjax
    {
        public static List<CatCustomModel> GetCatOfType(string maloai)
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();

            CatDbContext data = new CatDbContext();
            var cattable = data.Meos;
            var typecat = data.LoaiMeos;

            var item = (from a in cattable
                        join b in typecat on a.Ma_Loai equals b.Ma_Loai
                        where b.Ma_Loai == maloai
                        select new
                        {
                            id = a.Id,
                            img = a.img,
                            tenloai = b.TenLoai,
                            gia = a.GiaBan,
                            like=a.luot_like
                        }).ToList();
            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img,
                    GiaBan = i.gia
                    
                });
            }
            return listcats;
        }
    }
}