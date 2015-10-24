using System;
using System.Collections.Generic;
using MobiShop.Core.Model;

namespace MobiShop.WebUI.Models
{
    public class DisplayListProductViewModel
    {
        public IEnumerable<Product> Entities { get; set; }
        public string DisplayName { get; set; }
    }
}