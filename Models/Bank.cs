using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Models
{
    public class Bank
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Length should not be greater than 100")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MinLength(6, ErrorMessage = "Length should not be less than or greater than 6")]
        [MaxLength(6, ErrorMessage = "Length should not be less than or greater than 6")]
        public string? Bsbcode { get; set; }
        [Required]
        public string? account { get; set; }
        [Required]
        public User? User { get; set; }
    }
}