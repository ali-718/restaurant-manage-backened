using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Models
{
    public class Shifts
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public User? User { get; set; }
    }
}