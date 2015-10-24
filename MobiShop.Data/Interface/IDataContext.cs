using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MobiShop.Core.Model;

namespace MobiShop.Data.Interface
{
    public interface IDataContext: IDisposable
    {
        IDbSet<T> DbSet<T>() where T : PersistentEntity;
        DbEntityEntry<T> EntryGet<T>(T entity) where T : PersistentEntity;
        int Commit();
    }
}
