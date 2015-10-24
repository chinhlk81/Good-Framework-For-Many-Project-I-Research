using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminOrderService : OrderService, IAdminOrderService
    {
        protected new readonly IAdminRepository<Order> Repository;

        public AdminOrderService(IAdminRepository<Order> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
