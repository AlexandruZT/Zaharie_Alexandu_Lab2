namespace Zaharie_Alexandu_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; } = default!;
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}