using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Title { get; set; }
        [Display ()]
        public int AuthorId { get; set; }

        public string Genre { get; set; }

        public int YearPublished { get; set; }

        public int Rating {get; set; }
        public Author Author { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
