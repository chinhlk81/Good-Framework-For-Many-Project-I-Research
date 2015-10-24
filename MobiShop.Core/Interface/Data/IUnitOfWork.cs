using System;

namespace MobiShop.Core.Interface.Data
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}
