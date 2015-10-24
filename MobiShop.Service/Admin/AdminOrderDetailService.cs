using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminOrderDetailService : OrderDetailService, IAdminOrderDetailService
    {
        protected new readonly IAdminRepository<OrderDetail> Repository;

        public AdminOrderDetailService(IAdminRepository<OrderDetail> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
