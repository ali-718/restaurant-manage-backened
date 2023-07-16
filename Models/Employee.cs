using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Manage_Backened.Helpers.Enums;

namespace Restaurant_Manage_Backened.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public Designation? Designation { get; set; }
        public int salary { get; set; }
        public DateTime doj { get; set; }
        public int TFN { get; set; }
        public Super? Super { get; set; }
        public string Address { get; set; } = string.Empty;
        public string emailaddress { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Bank? Bank { get; set; }
    }
}