using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Controllers
{
    // [NonController] bu komut ile Controller dışardan request almaz.
    public class ProductController : Controller
    {
        //public IActionResult GetProducts()
        //{

        //    ViewResult result = View();
        //     //return View();
        //      return result;            
        //}

        #region ViewResult
        //GERİYE VİEW DÖNDÜRMEK İÇİN KULLANILIR
        //public ViewResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return result;
        //}
        #endregion

        #region PartialViewResult

        //AJAX İŞLEMLERİNDE GERİYE VİEW DÖNDÜRMEK İÇİN KULLANILIR.
        //CLINT TABANLI İŞLEMLER İÇİN KULLANILIR
        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult result = new PartialViewResult();
        //    return result;
        //}
        #endregion

        #region JsonResult
        //CLIENT TABANLI İŞLEMLERDE KULLANILIR,AJAX İŞLEMLERİNDE KULLANILIR
        //SAYFANIN TÜM YAPISINI JSON FORMATINA ÇEVİRİR
        //public JsonResult GetProducts()
        //{
        // JsonResult result=  Json(new Product
        //    {
        //        Id = 5,
        //        ProductName = "Klavye",
        //        Quantity = 15
        //    }
        //        );

        //    return result;

        //}

        #endregion

        #region EmptyResult

        //Result boş döner, Herhangi bir değeri olmaz
        //public EmptyResult GetProducts()
        //{

        //    return new EmptyResult();
        //}

        //Void EmptyResult 'un muadilidir

        //public void GetProducts()
        //{


        //}
        #endregion

        #region ContentResult
        //STRİNG DEĞER DÖNDÜRÜR,
        //CLIENT TABANLI İŞLEMLERDE KULLANILIR,AJAX İŞLEMLERİNDE KULLANILIR
        //SAYFANIN TÜM YAPISINI JSON FORMATINA ÇEVİRİR
        //public ContentResult GetProducts()
        //{

        //    ContentResult result = Content("SERGEN KAYĞIN");
        //    return result;

        //}

        #endregion

        #region IACTIONRESULT
        //ACTIONRESULT UN Interface idir,

        //public IActionResult GetProducts()
        //{

        //    ContentResult result = Content("SERGEN KAYĞIN");
        //    return result;

        //}
        #endregion


        #region ACTIONRESULT
        //ACTIONRESULTLARIN ATASIDIR.
        //İSTEDİĞİN TÜRDE DÖNÜŞ YAPAR
        //ORTAK TÜR  SAĞLAR
        //GENEL OLARAK İSTEK NETİCESİNDE ŞART DURUMLARINI KONTROL EDİLİR

        #endregion

        #region VIEWCONPONENTRESULT
        //ViewComponent geriye döndürmek için kullanılır

        #endregion


        #region NONACTIONS
        // [NonAction] Actions olmaktan çıkar, dışardan request almaz , iş yapan metod olur
        //[NonAction] 
        //public void X ()
        //{

        //}
        #endregion


        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{Id=1,ProductName="Klavye",Quantity=10},
                new Product{Id=2,ProductName="Monitör",Quantity=20},
                new Product{Id=3,ProductName="Mouse",Quantity=30},
            };


            #region Modül Bazlı Veri Gönderimi
            //return View(products);
            #endregion

            #region Veri Taşıma Yöntemleri

            #region ViewBag
            //View gönderecek veriyi dynamic olarak gönderir

            //ViewBag.products = products;

            #endregion


            #region ViewData
            //ViewBag gibi View ' e veri taşımaya yarar.
            //View gönderecek veriyi an boxing olarak değişir.

            //ViewData["products"] = products;

            #endregion

            #region TempData
            //ViewBag gibi View ' e veri taşımaya yarar.
            //View gönderecek veriyi an boxing olarak değişir.

            //TempData["products"] = products;

            TempData["x"] = 5;
            ViewData["x"] = 5;
            ViewBag.x = 5;

            #endregion


            #endregion

            return RedirectToAction("Index2");

        }

        public IActionResult Index2 ()
        {
            var v1 = ViewBag.x;
            var v2 = ViewData["x"];
            var v3 = TempData["x"];

            return View();
        }

    }
}
