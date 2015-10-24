using System;
using System.Collections.Generic;
using System.Linq;
using MobiShop.Data.Interface;
using MobiShop.Common.Disposable;

namespace MobiShop.Data
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private IDataContext dataContext;

        public IDataContext Get()
        {
            return dataContext ?? (dataContext = new MobiShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null) dataContext.Dispose();
        }
    }
}
