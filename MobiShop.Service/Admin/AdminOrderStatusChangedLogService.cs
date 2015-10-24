using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminOrderStatusChangedLogService : OrderStatusChangedLogService, IAdminOrderStatusChangedLogService
    {
        protected new readonly IAdminRepository<OrderStatusChangedLog> Repository;

        public AdminOrderStatusChangedLogService(IAdminRepository<OrderStatusChangedLog> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
