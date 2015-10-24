using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobiShop.Core.Interface.Service;
using MobiShop.WebUI.Infrastructure;

namespace MobiShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private int numberProductDisplayAtHomePage = AppSettings.NumberProductDisplayAtHomePage;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public ActionResult Index()
        {
            ViewBag.ProductNewest = productService.GetNewest(numberProductDisplayAtHomePage);
            ViewBag.ProductBestBuy = productService.GetBestBuy(numberProductDisplayAtHomePage);
            ViewBag.ProductMostView = productService.GetMostView(numberProductDisplayAtHomePage);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
