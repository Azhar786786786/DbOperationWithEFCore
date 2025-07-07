namespace DBOperationsWithEFCore.Models
{
    public class CurrencyType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BookPrice> BookPrices { get; set; }
    }
}
