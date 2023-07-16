using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        public Customer? Customer { get; set; }
        public Tables? Table { get; set; }
    }
}