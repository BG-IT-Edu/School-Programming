namespace BookShop.Initializer
{
    using System;

    using Data;
    using Models;
    using Generators;

    public class DbInitializer
    {
        public static void ResetDatabase(BookShopContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Console.WriteLine("BookShop database created successfully.");

            Seed(context);
        }

        public static void Seed(BookShopContext context)
        {
            Book[] books = BookGenerator.CreateBooks();

            context.Books.AddRange(books);

            context.SaveChanges();

            Console.WriteLine("Sample data inserted successfully.");
        }
    }
}
