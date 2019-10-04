using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatShop.Models;
using System.Linq;


namespace CatShop.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            MultiCustomModel multicus = new MultiCustomModel();

            multicus.ModelCAT_CarouselStart.AddRange(GetCatCarouselStart());
            multicus.ModelCAT_Trending.AddRange(GetCatTrending());
            multicus.ModelCAT_BestSeller.AddRange(GetCatBestSeller());
            multicus.ModelCAT_BlogSection.AddRange(GetSellCatBlogSection());
            return View(multicus);
        }

        public List<CatCustomModel> GetCatCarouselStart()
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();
            
            CAT_SHOP1Entities1 data = new CAT_SHOP1Entities1();
            var bestcattable = data.BestCats;
            var cattable = data.Meos;
            var typecat=data.LoaiMeos;
            //full best cat if check = 1
            var item = (from a in bestcattable
                        join b in cattable on a.Id equals b.Id
                        join c in typecat on b.Ma_Loai equals c.Ma_Loai
                        where a.Check_cat == 1
                        select new
                        {
                            id = b.Id,
                            img = b.img,
                            tenloai=c.TenLoai,
                            gia=b.GiaBan
                        }).ToList();

            //
            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img,
                    TenLoaiMeo = i.tenloai,
                    GiaBan=i.gia
                });
            }
            return listcats;
        }

        public List<CatCustomModel> GetCatTrending()
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();
            CAT_SHOP1Entities1 data = new CAT_SHOP1Entities1();
            var catmaxmoney = data.MaxMonneyCats;
            var cattable = data.Meos;
            var typecat = data.LoaiMeos;
            var item = (from a in catmaxmoney
                        join b in cattable on a.Id equals b.Id
                        join c in typecat on b.Ma_Loai equals c.Ma_Loai
                        where a.Check_cat == 1
                        select new
                        {
                            id = b.Id,
                            img = b.img,
                            ngaytuoi=b.Ngaytuoi,
                            tenloaimeo=c.TenLoai,
                            gia=b.GiaBan
                        }).ToList();

            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img,
                    Ngaytuoi=i.ngaytuoi,
                    TenLoaiMeo=i.tenloaimeo,
                    GiaBan=i.gia
                });
            }
            return listcats;
        }


        public List<CatCustomModel> GetCatBestSeller()
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();
            CAT_SHOP1Entities1 data = new CAT_SHOP1Entities1();
            var catseller = data.SellerCats;
            var cattable = data.Meos;
            var typecat = data.LoaiMeos;
            var item = (from a in catseller
                        join b in cattable on a.Id equals b.Id
                        join c in typecat on b.Ma_Loai equals c.Ma_Loai
                        where a.Check_cat == 1
                        select new
                        {
                            id = b.Id,
                            img = b.img,
                            gia=b.GiaBan,
                            giam = Convert.ToInt32(b.GiaBan) - Convert.ToInt32(b.GiaBan)*a.TiLeGiam

                        }).ToList();

            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img,
                    GiaBan=i.gia,
                    giamoi=Convert.ToString(i.giam)
                });
            }
            return listcats;
        }

        public List<CatCustomModel> GetSellCatBlogSection()
        {
            List<CatCustomModel> listcats = new List<CatCustomModel>();
            CAT_SHOP1Entities1 data = new CAT_SHOP1Entities1();
            var cattable = data.LastNews;
            var cattable1 = data.Meos;
            var item = (from a in cattable
                        join b in cattable1 on a.Id equals b.Id
                        where a.Check_cat == 1
                        select new
                        {
                            id = b.Id,
                            img = b.img
                        }).ToList();

            foreach (var i in item)
            {
                listcats.Add(new CatCustomModel
                {
                    Id = i.id,
                    img = i.img
                });
            }
            return listcats;
        }


        public ActionResult Shop()
        {
            return View();
        }


    }
}
