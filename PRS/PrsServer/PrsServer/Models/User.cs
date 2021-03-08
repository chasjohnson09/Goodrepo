﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrsServer.Models
{
    public class User
    {
        public User() { }

        public int Id { get; set; }
        [StringLength(30),Required]
        public string Username { get; set; }
        [StringLength(30), Required]
        public string Password { get; set; }
        [StringLength(30), Required]
        public string Firstname { get; set; }
        [StringLength(30), Required]
        public string Lastname { get; set; }
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public bool IsReviewer { get; set; }
        public bool IsAdmin { get; set; }
    }
}
