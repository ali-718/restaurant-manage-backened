using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Manage_Backened.Helpers.Enums;

namespace Restaurant_Manage_Backened.Models
{
    public class Ingredients
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Units? Units { get; set; }
        public List<Inventory>? Inventory { get; set; }
        public int Quantity { get; set; }
    }
}