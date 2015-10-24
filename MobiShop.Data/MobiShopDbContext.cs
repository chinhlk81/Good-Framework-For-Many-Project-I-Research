using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MobiShop.Core.Model;
using MobiShop.Data.Interface;

namespace MobiShop.Data
{
    public class MobiShopDbContext: DbContext, IDataContext
    {
        public MobiShopDbContext()
            : base("name=DefaultConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    
        public DbSet<Company> Companies { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderStatusChangedLog> OrderStatusChangedLogs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public IDbSet<T> DbSet<T>() where T : PersistentEntity
        {
            return this.Set<T>();
        }

        public DbEntityEntry<T> EntryGet<T>(T entity) where T : PersistentEntity
        {
            return this.Entry<T>(entity);
        }

        public virtual int Commit()
        {
            return this.SaveChanges();
        }
    }
}
