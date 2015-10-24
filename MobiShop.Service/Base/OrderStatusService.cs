using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;

namespace MobiShop.Service.Base
{
    public partial class OrderStatusService : BaseService<OrderStatus>, IOrderStatusService
    {
        public OrderStatusService(IRepository<OrderStatus> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }
}
