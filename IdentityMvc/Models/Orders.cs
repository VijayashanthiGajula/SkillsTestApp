 
using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMvc.Models
{
    public class Orders
    {
        public Orders()
        {
        }
        [Key]
        public int OrderId { get; set; }
        [Required]
        public double Price { get; set; }
        public int quantity { get; set; }
        public int IdentityUser { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual OrderItems OrderItems { get; set; }
        
    }

    
}
