using System;
using System.Linq;
using MobiShop.Core.Model;

namespace MobiShop.Core.Interface.Service
{
    public partial interface IProductService: IService<Product>
    {
    }

    public partial interface IProductService
    {
        IQueryable<Product> GetNewest(int quantity);
        IQueryable<Product> GetBestBuy(int quantity);
        IQueryable<Product> GetMostView(int quantity);
        Product GetRandomProduct();
    }
}
