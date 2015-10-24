using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiShop.Core.Model
{
    [Table("Manufacture")]
    public partial class Manufacture : PersistentEntity
    {
        public Manufacture()
        {
            this.Products = new HashSet<Product>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Position { get; set; }
        public string LogoImage { get; set; }
        public bool Deleted { get; set; }
        public string NameUnsign { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
