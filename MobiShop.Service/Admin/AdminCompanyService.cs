using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminCompanyService : CompanyService, IAdminCompanyService
    {
        protected new readonly IAdminRepository<Company> Repository;

        public AdminCompanyService(IAdminRepository<Company> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
