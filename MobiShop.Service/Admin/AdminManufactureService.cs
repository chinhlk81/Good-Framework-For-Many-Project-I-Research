using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;
using MobiShop.Service.Base;

namespace MobiShop.Service.Admin
{
    public partial class AdminManufactureService : ManufactureService, IAdminManufactureService
    {
        protected new readonly IAdminRepository<Manufacture> Repository;

        public AdminManufactureService(IAdminRepository<Manufacture> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            this.Repository = repository;
        }
    }
}
