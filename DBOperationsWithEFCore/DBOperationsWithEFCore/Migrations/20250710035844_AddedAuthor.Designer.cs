﻿// <auto-generated />
using System;
using DBOperationsWithEFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBOperationsWithEFCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250710035844_AddedAuthor")]
    partial class AddedAuthor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DBOperationsWithEFCore.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DBOperationsWithEFCore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("NoOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DBOperationsWithEFCore.Models.BookPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("BookPrices");
                });

            modelBuilder.Entity("DBOperationsWithEFCore.Models.CurrencyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Indian INR",
                            Title = "INR"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dollar",
                            Title = "Dollar"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Euro",
                            Title = "Euro"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Kuwaiti Dinar",
                            Title = "Dinar"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Saudi Riyal",
                            Title = "Riyal"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Thailand Currency",
                            Title = "Baht"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Japan Currency",
                            Title = "Yen"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Russian Rouble",
                            Title = "RUB"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Chinese Yuan Renminbi",
                            Title = "Yuan"
                        });
                });

            modelBuilder.Entity("DBOperationsWithEFCore.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Hindi",
                            Title = "Hindi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Urdu",
                            Title = "Urdu"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Arabic",
                            Title = "Arabic"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Tamil",
                            Title = "Tamil"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Punjabi",
                            Title = "Punjabi"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Telugu",
                            Title = "Telugi"
                        },
                        new
                        {
                            Id = 7,
                            Description = "English",
                            Title = "English"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Bhojpuri",
                            Title = "Bhojpuri"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Marathi",
                            Title = "Marathi"
                        });
                });

            modelBuilder.Entity("DBOperationsWithEFCore.Models.Book", b =>
                {
                    b.HasOne("DBOperationsWithEFCore.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("DBOperationsWithEFCore.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("DBOperationsWithEFCore.Models.BookPrice", b =>
                {
                    b.HasOne("DBOperationsWithEFCore.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBOperationsWithEFCore.Models.CurrencyType", "Currency")
                        .WithMany("BookPrices")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("DBOperationsWithEFCore.Models.CurrencyType", b =>
                {
                    b.Navigation("BookPrices");
                });

            modelBuilder.Entity("DBOperationsWithEFCore.Models.Language", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
