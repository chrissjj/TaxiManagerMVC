﻿using System.ComponentModel.DataAnnotations;
using TaxiManager.Enums;

namespace TaxiManager.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Username { get; set; } = null!;
        [Required]
        [MinLength(5, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; } = null!;
        public Role Role { get; set; }
    }
}
