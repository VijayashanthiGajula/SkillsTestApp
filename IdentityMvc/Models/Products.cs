using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMvc.Models
{
    public class Products
    {
        public Products()
        {
            OrderItems = new HashSet<OrderItems>();
        }
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
       public int? Quantity { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }

       

    }
}
