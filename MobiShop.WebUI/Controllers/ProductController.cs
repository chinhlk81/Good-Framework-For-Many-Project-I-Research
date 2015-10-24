using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobiShop.WebUI.Infrastructure;
using MobiShop.WebUI.Models;
using MobiShop.Core.Interface.Service;

namespace MobiShop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IManufactureService manuService;
        public int ListByManufacureIdNumberPerPage { get; set; }

        public ProductController(IProductService productService, IManufactureService manuService,IProductService productService, )
        {
            this.productService = productService;
            this.manuService = manuService;
            ListByManufacureIdNumberPerPage = AppSettings.ListByManufacureIdNumberPerPage;
        }

        [ChildActionOnly]
        public ActionResult DisplayRandomProduct()
        {
            return PartialView(productService.GetRandomProduct());
        }

        public ActionResult ListByManufacureId(string manufactureNameUnsign, int page = 1)
        {
            var Model=new ProductsByManufactureIdViewModel();
            var model = new ProductsByManufactureIdViewModel();
            model.Manufacture = manuService.Get(m => m.NameUnsign == manufactureNameUnsign);
            if (model.Manufacture == null) return View(model);

            model.PagingProducts = productService.Page(p => p.ManufactureId == model.Manufacture.Id, p => p.Id, page, ListByManufacureIdNumberPerPage);
            return View(model);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
