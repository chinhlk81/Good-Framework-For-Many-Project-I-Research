using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiShop.Core.Model
{
    [Table("UserProfile")]
    public partial class UserProfile : PersistentEntity
    {
        public UserProfile()
        {
            this.Orders = new HashSet<Order>();
            this.OrderStatusChangedLogs = new HashSet<OrderStatusChangedLog>();
            this.ProductComments = new HashSet<ProductComment>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string PhoneNumber { get; set; }
        
        public bool Banned { get; set; }
        public string BannedReason { get; set; }
        public Nullable<System.DateTime> BannedExpireDate { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        
        public string IdentityCardNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderStatusChangedLog> OrderStatusChangedLogs { get; set; }
        public virtual ICollection<ProductComment> ProductComments { get; set; }
    }
}
