using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Models
{
    public class Tables
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool isTemporary { get; set; }
        public int persons { get; set; }
    }
}