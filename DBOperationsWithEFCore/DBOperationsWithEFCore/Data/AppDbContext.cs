using DBOperationsWithEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCore.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                new CurrencyType() { Id = 1, Title = "INR", Description = "Indian INR" },
                new CurrencyType() { Id = 2, Title = "Dollar", Description = "Dollar" },
                new CurrencyType() { Id = 3, Title = "Euro", Description = "Euro" },
                new CurrencyType() { Id = 4, Title = "Dinar", Description = "Kuwaiti Dinar" },
                new CurrencyType() { Id = 5, Title = "Riyal", Description = "Saudi Riyal" },
                new CurrencyType() { Id = 6, Title = "Baht", Description = "Thailand Currency" },
                new CurrencyType() { Id = 7, Title = "Yen", Description = "Japan Currency" },
                new CurrencyType() { Id = 8, Title = "RUB", Description = "Russian Rouble" },
                new CurrencyType() { Id = 9, Title = "Yuan", Description = "Chinese Yuan Renminbi" }
                );

            modelBuilder.Entity<Language>().HasData(
               new Language() { Id = 1, Title = "Hindi", Description = "Hindi" },
               new Language() { Id = 2, Title = "Urdu", Description = "Urdu" },
               new Language() { Id = 3, Title = "Arabic", Description = "Arabic" },
               new Language() { Id = 4, Title = "Tamil", Description = "Tamil" },
               new Language() { Id = 5, Title = "Punjabi", Description = "Punjabi" },
               new Language() { Id = 6, Title = "Telugi", Description = "Telugu" },
               new Language() { Id = 7, Title = "English", Description = "English" },
               new Language() { Id = 8, Title = "Bhojpuri", Description = "Bhojpuri" },
               new Language() { Id = 9, Title = "Marathi", Description = "Marathi" }
               );

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<CurrencyType> Currencies { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
