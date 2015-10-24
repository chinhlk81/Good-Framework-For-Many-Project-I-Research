using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminUserProfileService : UserProfileService, IAdminUserProfileService
    {
        protected new readonly IAdminRepository<UserProfile> Repository;

        public AdminUserProfileService(IAdminRepository<UserProfile> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
