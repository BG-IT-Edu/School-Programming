namespace BookShop.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public Category()
        {
            this.CategoryBooks = new HashSet<BookCategory>();
        }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<BookCategory> CategoryBooks { get; set; }
    }
}