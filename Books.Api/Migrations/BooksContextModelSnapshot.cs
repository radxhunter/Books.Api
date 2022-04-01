﻿// <auto-generated />
using System;
using Books.Api.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Books.Api.Migrations
{
    [DbContext(typeof(BooksContext))]
    partial class BooksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Books.Api.Entites.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9071cc99-3b94-4ce8-80fd-70298004faa6"),
                            FirstName = "Radek",
                            LastName = "Heheszek"
                        },
                        new
                        {
                            Id = new Guid("95201deb-46bf-4392-9ed0-b0e35cc331c7"),
                            FirstName = "Adrian",
                            LastName = "Hehyszek"
                        },
                        new
                        {
                            Id = new Guid("c14cc7f2-c7cd-4484-9de6-21bbd9507918"),
                            FirstName = "Rafał",
                            LastName = "Koń"
                        },
                        new
                        {
                            Id = new Guid("749db0c5-92c2-47c3-b376-fdf55b46fdcd"),
                            FirstName = "Mieczysław",
                            LastName = "Psikuta"
                        },
                        new
                        {
                            Id = new Guid("ec06d464-948e-4701-bd05-deea46e28c67"),
                            FirstName = "Gracjan",
                            LastName = "Obsidian"
                        });
                });

            modelBuilder.Entity("Books.Api.Entites.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Books.Api.Entites.Book", b =>
                {
                    b.HasOne("Books.Api.Entites.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
