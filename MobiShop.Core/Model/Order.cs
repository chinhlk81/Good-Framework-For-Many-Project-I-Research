using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiShop.Core.Model
{
    [Table("Order")]
    public partial class Order : PersistentEntity
    {
        public Order()
        {
            this.OrderStatusChangedLogs = new HashSet<OrderStatusChangedLog>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityCardNumber { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> OrderStatusId { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        
        public Nullable<System.DateTime> ShipDate { get; set; }
        
        public string PublicComment { get; set; }
        public string PrivateComment { get; set; }

        public virtual ICollection<OrderStatusChangedLog> OrderStatusChangedLogs { get; set; }
        [ForeignKey("CustomerId")]
        public virtual UserProfile UserProfile { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
