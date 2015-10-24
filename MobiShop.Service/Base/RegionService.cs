using System;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;

namespace MobiShop.Service.Base
{
    public partial class RegionService : BaseService<Region>, IRegionService
    {
        public RegionService(IRepository<Region> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }
}
