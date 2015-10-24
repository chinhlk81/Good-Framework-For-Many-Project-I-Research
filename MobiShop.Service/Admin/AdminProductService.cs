using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminProductService : ProductService, IAdminProductService
    {
        protected new readonly IAdminRepository<Product> Repository;

        public AdminProductService(IAdminRepository<Product> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
