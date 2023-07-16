using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Models
{
    public class Super
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public int account { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}