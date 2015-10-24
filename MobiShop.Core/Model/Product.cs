using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiShop.Core.Model
{
    [Table("Product")]
    public partial class Product : PersistentEntity
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.ProductComments = new HashSet<ProductComment>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public int TotalView { get; set; }
        public int TotalSale { get; set; }
        public int TotalQuantity { get; set; }
        public Nullable<int> ManufactureId { get; set; }
        
        public Nullable<int> RegionId { get; set; }
        public string NameUnsign { get; set; }
        

        public virtual Manufacture Manufacture { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductComment> ProductComments { get; set; }
        public virtual Region Region { get; set; }
    }
}
