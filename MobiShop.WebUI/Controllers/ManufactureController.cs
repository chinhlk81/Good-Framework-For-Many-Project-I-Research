using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobiShop.Core.Interface.Service;

namespace MobiShop.WebUI.Controllers
{
    public class ManufactureController : Controller
    {
        private readonly IManufactureService manuService;

        public ManufactureController(IManufactureService manuService)
        {
            this.manuService = manuService;
        }

        [ChildActionOnly]
        public PartialViewResult Menu()
        {
            return PartialView(manuService.GetAll(true));
        }

    }
}
