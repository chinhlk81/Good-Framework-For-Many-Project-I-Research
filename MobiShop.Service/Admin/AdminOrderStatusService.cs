using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminOrderStatusService : OrderStatusService, IAdminOrderStatusService
    {
        protected new readonly IAdminRepository<OrderStatus> Repository;

        public AdminOrderStatusService(IAdminRepository<OrderStatus> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
