using Zaharie_Alexandu_Lab2.Models;

namespace Zaharie_Alexandu_Lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}   