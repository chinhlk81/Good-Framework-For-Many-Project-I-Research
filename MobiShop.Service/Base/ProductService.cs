using System;
using System.Linq;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;

namespace MobiShop.Service.Base
{
    public partial class ProductService: BaseService<Product>, IProductService
    {
        public ProductService(IRepository<Product> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public partial class ProductService
    {
        public IQueryable<Product> GetNewest(int quantity)
        {
            return this.GetAll()
                .OrderByDescending(p => p.CreateDate)
                .Take(quantity);
        }

        public IQueryable<Product> GetBestBuy(int quantity)
        {
            return this.GetAll()
                .OrderByDescending(p => p.TotalSale)
                .Take(quantity);
        }

        public IQueryable<Product> GetMostView(int quantity)
        {
            return this.GetAll()
                .OrderByDescending(p => p.TotalView)
                .Take(quantity);
        }

        public Product GetRandomProduct()
        {
            Random random = new Random();
            return this.GetAll()
                .OrderBy(p => p.Id)
                .Skip(random.Next(this.GetAll().Count()))
                .FirstOrDefault();
        }
    }
}
