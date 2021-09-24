namespace BookShop.Initializer.Generators
{
    using BookShop.Models;

    internal class CategoryGenerator 
    {
        internal static Category[] CreateCategories()
        {
            string[] categoryNames = new string[]
            {
                "Science Fiction",
                "Drama",
                "Action",
                "Adventure",
                "Romance",
                "Mystery",
                "Horror",
                "Health",
                "Travel",
                "Children's",
                "Science",
                "History",
                "Poetry",
                "Comics",
                "Art",
                "Cookbooks",
                "Journals",
                "Biographies",
                "Fantasy",
            };

            int categoryCount = categoryNames.Length;

            Category[] categories = new Category[categoryCount];

            for (int i = 0; i < categoryCount; i++)
            {
                Category category = new Category()
                {
                    Name = categoryNames[i],
                };

                categories[i] = category;
            }

            return categories;
        }
    }
}
