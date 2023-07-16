using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Menu>? Menus { get; set; }
        public string Mobile { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Orders>? Orders { get; set; }
    }
}