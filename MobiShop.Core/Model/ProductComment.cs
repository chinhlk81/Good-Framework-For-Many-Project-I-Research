using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiShop.Core.Model
{
    [Table("ProductComment")]
    public partial class ProductComment : PersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> UserProfileId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastEditedDate { get; set; }


        public virtual Product Product { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
