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
                new CurrencyType() { Id = 4, Title = "Dinar", Description = "Dinar" },
                new CurrencyType() { Id = 5, Title = "Riyal", Description = "Riyal" },
                new CurrencyType() { Id = 6, Title = "Bott", Description = "Bott" }
                );

            modelBuilder.Entity<Language>().HasData(
               new Language() { Id = 1, Title = "Hindi", Description = "Hindi" },
               new Language() { Id = 2, Title = "Tamil", Description = "Tamil" },
               new Language() { Id = 3, Title = "Punjabi", Description = "Punjabi" },
               new Language() { Id = 4, Title = "Urdu", Description = "Urdu" },
               new Language() { Id = 5, Title = "English", Description = "English" },
               new Language() { Id = 6, Title = "Bhojpuri", Description = "Bhojpuri" }
               );

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<CurrencyType> Currencies { get; set; }
        //public DbSet<Author> Authors { get; set; }
    }
}
