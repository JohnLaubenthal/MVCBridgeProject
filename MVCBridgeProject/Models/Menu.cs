using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBridgeProject.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public int Item { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}