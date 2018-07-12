﻿using System;
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
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
    }
}