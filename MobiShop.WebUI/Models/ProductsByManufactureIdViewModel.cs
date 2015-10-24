using System;
using System.Collections.Generic;
using MobiShop.Core.Model;
using MobiShop.Common.Paging;

namespace MobiShop.WebUI.Models
{
    public class ProductsByManufactureIdViewModel
    {
        public Manufacture Manufacture { get; set; }
        public IPage<Product> PagingProducts { get; set; }
    }
}