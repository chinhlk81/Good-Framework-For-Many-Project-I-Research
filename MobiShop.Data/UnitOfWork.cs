using System;
using System.Collections.Generic;
using System.Linq;
using MobiShop.Core.Interface.Data;
using MobiShop.Data.Interface;

namespace MobiShop.Data
{
    public class UnitOfWork: IUnitOfWork
    {
        private IDataContext dataContext;
        private readonly IDatabaseFactory databaseFactory;

        protected IDataContext DataContext
        {
            get
            {
                return dataContext ?? (dataContext = databaseFactory.Get());
            }
        }

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        public int Commit()
        {
            return DataContext.Commit();
        }
    }
}
