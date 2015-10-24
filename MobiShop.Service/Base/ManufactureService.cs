using System;
using System.Linq;
using MobiShop.Core.Model;
using MobiShop.Core.Interface.Service;
using MobiShop.Core.Interface.Data;

namespace MobiShop.Service.Base
{
    public partial class ManufactureService: BaseService<Manufacture>, IManufactureService
    {
        public ManufactureService(IRepository<Manufacture> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {

        }
    }

    public partial class ManufactureService
    {
        public IQueryable<Manufacture> GetAll(bool ascending)
        {
            return ascending ? GetAll().OrderBy(m => m.Position)
                : GetAll().OrderByDescending(m => m.Position);
        }
    }
}
