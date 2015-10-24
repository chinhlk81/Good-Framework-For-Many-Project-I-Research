using System;

namespace MobiShop.Data.Interface
{
    public interface IDatabaseFactory: IDisposable
    {
        IDataContext Get();
    }
}
