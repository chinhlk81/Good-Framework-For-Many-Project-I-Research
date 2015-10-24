using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;

namespace MobiShop.Service.Base
{
    public partial class ProductCommentService : BaseService<ProductComment>, IProductCommentService
    {
        public ProductCommentService(IRepository<ProductComment> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }
}
