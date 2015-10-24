using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiShop.Core.Model
{
    [Table("OrderStatus")]
    public partial class OrderStatus : PersistentEntity
    {
        public OrderStatus()
        {
            this.Orders = new HashSet<Order>();
            this.NewOrderStatusChangedLogs = new HashSet<OrderStatusChangedLog>();
            this.OldOrderStatusChangedLogs = new HashSet<OrderStatusChangedLog>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderStatusChangedLog> NewOrderStatusChangedLogs { get; set; }
        public virtual ICollection<OrderStatusChangedLog> OldOrderStatusChangedLogs { get; set; }
    }
}
