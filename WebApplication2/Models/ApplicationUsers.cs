﻿using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models
{
    public class ApplicationUsers : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime CreateDate { get; set; } 
    }
}
