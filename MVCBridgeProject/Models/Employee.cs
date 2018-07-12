using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBridgeProject.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int EmployeeNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public int EmergencyContactNumber{ get; set; }
        public DateTime PublishedDate { get; set; }
    }
}