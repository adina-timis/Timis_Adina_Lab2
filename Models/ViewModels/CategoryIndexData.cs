namespace Timis_Adina_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
