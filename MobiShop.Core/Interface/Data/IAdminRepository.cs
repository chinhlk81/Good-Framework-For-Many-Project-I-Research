using System;
using System.Collections.Generic;
using System.Linq;

namespace MobiShop.Core.Interface.Data
{
    public interface IAdminRepository<T> : IRepository<T> where T : class
    {
    }
}
