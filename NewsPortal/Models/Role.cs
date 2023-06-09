﻿using NewsPortal.Areas.Admin.Models;
using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Role() 
        {
            Users = new List<User>();
        }   
    }
} 
