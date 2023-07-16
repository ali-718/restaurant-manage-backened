using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public List<Menu>? Menus { get; set; }
        public int Price { get; set; }
        public Customer? Customer { get; set; }
        public bool Takeaway { get; set; }
        public bool Paid { get; set; }
    }
}
