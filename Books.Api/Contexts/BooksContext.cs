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
                        FirstName = "Rafal",
                        LastName = "Kon"
                    },
                    new Author()
                    {
                        Id = Guid.Parse("749db0c5-92c2-47c3-b376-fdf55b46fdcd"),
                        FirstName = "Mieczyslaw",
                        LastName = "Psikuta"
                    },
                    new Author()
                    {
                        Id = Guid.Parse("ec06d464-948e-4701-bd05-deea46e28c67"),
                        FirstName = "Gracjan",
                        LastName = "Obsidian"
                    }
                );

            modelBuilder.Entity<Book>().HasData(
               new Book
               {
                   Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                   AuthorId = Guid.Parse("9071cc99-3b94-4ce8-80fd-70298004faa6"),
                   Title = "The Winds of Winter",
                   Description = "The book that seems impossible to write."
               },
               new Book
               {
                   Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                   AuthorId = Guid.Parse("9071cc99-3b94-4ce8-80fd-70298004faa6"),
                   Title = "A Game of Thrones",
                   Description = "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. ... In the novel, recounting events from various points of view, Martin introduces the plot-lines of the noble houses of Westeros, the Wall, and the Targaryens."
               },
               new Book
               {
                   Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                   AuthorId = Guid.Parse("95201deb-46bf-4392-9ed0-b0e35cc331c7"),
                   Title = "Mythos",
                   Description = "The Greek myths are amongst the best stories ever told, passed down through millennia and inspiring writers and artists as varied as Shakespeare, Michelangelo, James Joyce and Walt Disney.  They are embedded deeply in the traditions, tales and cultural DNA of the West.You'll fall in love with Zeus, marvel at the birth of Athena, wince at Cronus and Gaia's revenge on Ouranos, weep with King Midas and hunt with the beautiful and ferocious Artemis. Spellbinding, informative and moving, Stephen Fry's Mythos perfectly captures these stories for the modern age - in all their rich and deeply human relevance."
               },
               new Book
               {
                   Id = Guid.Parse("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                   AuthorId = Guid.Parse("c14cc7f2-c7cd-4484-9de6-21bbd9507918"),
                   Title = "American Tabloid",
                   Description = "American Tabloid is a 1995 novel by James Ellroy that chronicles the events surrounding three rogue American law enforcement officers from November 22, 1958 through November 22, 1963. Each becomes entangled in a web of interconnecting associations between the FBI, the CIA, and the mafia, which eventually leads to their collective involvement in the John F. Kennedy assassination."
               },
               new Book
               {
                   Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                   AuthorId = Guid.Parse("ec06d464-948e-4701-bd05-deea46e28c67"),
                   Title = "The Hitchhiker's Guide to the Galaxy",
                   Description = "In The Hitchhiker's Guide to the Galaxy, the characters visit the legendary planet Magrathea, home to the now-collapsed planet-building industry, and meet Slartibartfast, a planetary coastline designer who was responsible for the fjords of Norway. Through archival recordings, he relates the story of a race of hyper-intelligent pan-dimensional beings who built a computer named Deep Thought to calculate the Answer to the Ultimate Question of Life, the Universe, and Everything."
               }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
}
