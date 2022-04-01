using Books.Api.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Api.Contexts
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasData(
                    new Author()
                    {
                        Id = Guid.Parse("9071cc99-3b94-4ce8-80fd-70298004faa6"),
                        FirstName = "Radek",
                        LastName = "Heheszek"
                    },
                    new Author()
                    {
                        Id = Guid.Parse("95201deb-46bf-4392-9ed0-b0e35cc331c7"),
                        FirstName = "Adrian",
                        LastName = "Hehyszek"
                    },
                    new Author()
                    {
                        Id = Guid.Parse("c14cc7f2-c7cd-4484-9de6-21bbd9507918"),
                        FirstName = "Rafał",
                        LastName = "Koń"
                    },
                    new Author()
                    {
                        Id = Guid.Parse("749db0c5-92c2-47c3-b376-fdf55b46fdcd"),
                        FirstName = "Mieczysław",
                        LastName = "Psikuta"
                    },
                    new Author()
                    {
                        Id = Guid.Parse("ec06d464-948e-4701-bd05-deea46e28c67"),
                        FirstName = "Gracjan",
                        LastName = "Obsidian"
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
