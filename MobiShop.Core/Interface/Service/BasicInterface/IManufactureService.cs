using System;
using System.Linq;
using MobiShop.Core.Model;

namespace MobiShop.Core.Interface.Service
{
    public partial interface IManufactureService: IService<Manufacture>
    {
        IQueryable<Manufacture> GetAll(bool ascending);
    }
}
