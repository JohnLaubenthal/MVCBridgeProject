using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBridgeProject.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string FavoriteDrink { get; set; }
        public string FavoriteMeal { get; set; }
        public double LargestBill { get; set; }
        public virtual ICollection<Address>Addresses { get; set; }
    }
}