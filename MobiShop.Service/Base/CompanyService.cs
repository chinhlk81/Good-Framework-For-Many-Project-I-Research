using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;

namespace MobiShop.Service.Base
{
    public partial class CompanyService : BaseService<Company>, ICompanyService
    {
        public CompanyService(IRepository<Company> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }
}
