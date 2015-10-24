using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminProductCommentService : ProductCommentService, IAdminProductCommentService
    {
        protected new readonly IAdminRepository<ProductComment> Repository;

        public AdminProductCommentService(IAdminRepository<ProductComment> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
