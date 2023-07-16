using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Ingredients>? Ingredients { get; set; }
        public int Price { get; set; }
        public int Serving { get; set; }
        public List<Orders>? Orders { get; set; }
    }
}