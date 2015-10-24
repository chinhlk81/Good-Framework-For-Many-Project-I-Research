using System;
using System.Collections.Generic;
using System.Linq;
using MobiShop.Core.Interface.Data;
using MobiShop.Core.Model;
using MobiShop.Data.Interface;

namespace MobiShop.Data
{
    public class AdminRepository<T> : Repository<T>, IAdminRepository<T>
        where T : PersistentEntity
    {
        public override bool AllowDeletedItem
        {
            get
            {
                return true;
            }
        }

        public AdminRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        { }
    }
}
