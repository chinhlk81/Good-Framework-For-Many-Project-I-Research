using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;

namespace MobiShop.Service.Base
{
    public partial class OrderStatusChangedLogService : BaseService<OrderStatusChangedLog>, IOrderStatusChangedLogService
    {
        public OrderStatusChangedLogService(IRepository<OrderStatusChangedLog> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }
}
