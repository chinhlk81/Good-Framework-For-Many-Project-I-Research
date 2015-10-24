using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;

namespace MobiShop.Service.Base
{
    public partial class OrderService : BaseService<Order>, IOrderService
    {
        public OrderService(IRepository<Order> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }
}
