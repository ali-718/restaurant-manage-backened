using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Manage_Backened.Helpers.Enums;

namespace Restaurant_Manage_Backened.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category? Category { get; set; }
        public Units? Unit { get; set; }
        public int Quantity { get; set; }
        public DateTime DateRecieved { get; set; } = DateTime.Today;
        public DateTime? ExpiryDate { get; set; }
        public int Cost { get; set; }
        public int ThresholdQuantity { get; set; }
        public List<Ingredients>? Ingredients { get; set; }
    }
}