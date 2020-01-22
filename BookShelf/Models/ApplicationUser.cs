﻿using CsvHelper.Configuration.Attributes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string Lastname { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Book> Books { get; set; }

        public List<Author> Authors { get; set; }





    }
}
