using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using  IdentityMvc.Data.Migrations;
using Microsoft.AspNetCore.Identity;

namespace IdentityMvc.Models
{
    public class AspNetUsers:IdentityUser
    {
        
        public AspNetUsers()
        {
            Orders = new List<Orders>();
        }
       
        public virtual ICollection<Orders> Orders { get; set; }



    }
}