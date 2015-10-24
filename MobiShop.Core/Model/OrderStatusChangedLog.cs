using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiShop.Core.Model
{
    [Table("OrderStatusChangedLog")]
    public partial class OrderStatusChangedLog : PersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> PeopleRequestId { get; set; }
        public Nullable<int> OldOrderStatusId { get; set; }
        public Nullable<int> NewOrderStatusId { get; set; }
        public Nullable<System.DateTime> DateChange { get; set; }
        public string Comment { get; set; }

        public virtual Order Order { get; set; }
        [ForeignKey("NewOrderStatusId")]
        public virtual OrderStatus NewOrderStatus { get; set; }
        [ForeignKey("OldOrderStatusId")]
        public virtual OrderStatus OldOrderStatus { get; set; }
        [ForeignKey("PeopleRequestId")]
        public virtual UserProfile UserProfile { get; set; }
    }
}
