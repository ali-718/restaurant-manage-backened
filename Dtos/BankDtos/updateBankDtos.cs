using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Manage_Backened.Models;

namespace Restaurant_Manage_Backened.Dtos.BankDtos
{
    public class updateBankDtos
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Bsbcode { get; set; }
        public int account { get; set; }
        public User? User { get; set; }
    }
}
