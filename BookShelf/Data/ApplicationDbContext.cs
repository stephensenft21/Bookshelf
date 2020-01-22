using System;
using System.Collections.Generic;
using System.Text;
using BookShelf.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Book { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        ApplicationUser user = new ApplicationUser
        {
            FirstName = "admin",
            Lastname = "admin",
            UserName = "admin@admin.com",
            NormalizedUserName = "ADMIN@ADMIN.COM",
            Email = "admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.COM",
            EmailConfirmed = true,
            LockoutEnabled = false,
            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
            Id = "00000000-ffff-ffff-ffff-ffffffffffff"
        };
        
            var passwordHash = new PasswordHasher<ApplicationUser>();
        user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
        modelBuilder.Entity<ApplicationUser>().HasData(user);
   


            Author author1 = new Author
            {   Id = 1,
                Name = "Jimmy John",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author1);
            Author author2 = new Author
            {   Id = 2,
                Name = "Jersy Mike",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author2);
            Author author3 = new Author
            {   Id = 3,
                Name = "Jared Fogul",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author3);
            Book book1 = new Book
            {
                Id = 1,
                Title = "Jimmy John",
                ApplicationUserId = user.Id,
                YearPublished = 1990,
                AuthorId = author1.Id,
                Rating = 5,
                Genre = "Drama"
            };
            modelBuilder.Entity<Book>().HasData(book1);
            Book book2 = new Book
            {
                Id = 2,
                Title = "Jimmy John",
                ApplicationUserId = user.Id,
                YearPublished = 1990,
                AuthorId = author2.Id,
                Rating = 5,
                Genre = "Comedy"

            };
            modelBuilder.Entity<Book>().HasData(book2);
            Book book3 = new Book
            {
                Id = 3,
                Title = "Jimmy John",
                ApplicationUserId = user.Id,
                YearPublished = 1990,
                AuthorId = author3.Id,
                Rating = 5,
                Genre = "scary"

            };
            modelBuilder.Entity<Book>().HasData(book3);


            //Comments 
            Comment comment1 = new Comment
            {
                Id = 1,
                Text = "Jimmy Comment",
                BookId = 1,
                ApplicationUserId = user.Id,


            };
            modelBuilder.Entity<Comment>().HasData(comment1);
            Comment comment2 = new Comment
            {
                Id = 2,
                Text = "Jersey Comment",
                BookId = 2,
                ApplicationUserId = user.Id,


            };
            modelBuilder.Entity<Comment>().HasData(comment2);
            Comment comment3 = new Comment
            {
                Id = 3,
                Text = "Michael Comment",
                BookId = 3,
                ApplicationUserId = user.Id,


            };
            modelBuilder.Entity<Comment>().HasData(comment3);




        }

    }
}
