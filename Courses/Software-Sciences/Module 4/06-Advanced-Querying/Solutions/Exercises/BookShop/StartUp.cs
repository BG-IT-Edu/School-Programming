namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            Console.WriteLine(GetBooksByAgeRestriction(db, Console.ReadLine()));

            Console.WriteLine(GetGoldenBooks(db));

            Console.WriteLine(GetBooksByPrice(db));

            Console.WriteLine(GetBooksNotReleasedIn(db, 1998));

            var input = "horror mystery drama";

            Console.WriteLine(GetBooksByCategory(db, input));

            Console.WriteLine(GetBooksReleasedBefore(db, "12-04-1992"));

            Console.WriteLine(GetAuthorNamesEndingIn(db, "e"));

            Console.WriteLine(GetBookTitlesContaining(db, "sK"));

            Console.WriteLine(GetBooksByAuthor(db, "po"));

            Console.WriteLine(CountBooks(db, 40));

            Console.WriteLine(CountCopiesByAuthor(db));

            Console.WriteLine(GetTotalProfitByCategory(db));

            Console.WriteLine(GetMostRecentBooks(db));

            IncreasePrices(db);

            Console.WriteLine(RemoveBooks(db));
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var critery = Enum.Parse<AgeRestriction>(command, true);

            var books = context.Books
                .Where(x => x.AgeRestriction == critery)
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();


            var result = string.Join(Environment.NewLine, books);

            return result;



        }

        public static string GetGoldenBooks(BookShopContext context)
        {

            var goldenBooksTitles = context.Books.Where(x => x.EditionType == EditionType.Gold && x.Copies < 5000).Select(x => new
            {
                x.BookId,
                x.Title
            })
                .OrderBy(x => x.BookId)
                .ToList();

            var result = string.Join(Environment.NewLine, goldenBooksTitles.Select(x => x.Title));

            return result;


        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books.Where(x => x.Price > 40).Select(x => new
            {
                x.Title,
                x.Price
            })
                .OrderByDescending(x => x.Price)
                .ToList();

            var result = string.Join(Environment.NewLine, books.Select(x => $"{x.Title} - ${x.Price:f2}"));

            return result;
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books.Where(x => x.ReleaseDate.Value.Year != year).Select(x => new
            {
                x.BookId,
                x.Title
            })
                .OrderBy(x => x.BookId)
                .ToList();

            var result = string.Join(Environment.NewLine, books.Select(x => x.Title));

            return result;
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

            var books2 = context.Books.Where(x => x.BookCategories.Any(bc=>categories.Contains(bc.Category.Name)))
                .Select(x=>x.Title)
                .OrderBy(x=>x)
                .ToList();


            var result = string.Join(Environment.NewLine, books2);

            return result;


        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books.Where(x => DateTime.Compare(x.ReleaseDate.Value,parsedDate)<0)
                .Select(x=>new
                {
                    Title=x.Title,
                    EditionType=x.EditionType,
                    Price=x.Price,
                    ReleaseDate=x.ReleaseDate
                })
                .OrderByDescending(x=>x.ReleaseDate)
                .ToList();

            var result = string.Join(Environment.NewLine, books.Select(x => $"{x.Title} - {x.EditionType} - ${x.Price:f2}"));

            return result;



        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
               .ToList()
              .Where(x => x.FirstName.EndsWith(input))
             .Select(x => new
             {
                 FullName = String.Concat(x.FirstName," ", x.LastName)
             })
             .OrderBy(x => x.FullName)
             .ToList();

            var result = string.Join(Environment.NewLine, authors.Select(x => x.FullName));

            return result;
        }

         public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .ToList()
                .Where(x => x.Title.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(x => new
                {
                    x.Title
                })
                .OrderBy(x=>x.Title)
                .ToList();

            var result = string.Join(Environment.NewLine, books.Select(x=>x.Title));

            return result;
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {           
            var authorsBooks2 = context.Authors
                .Where(x => x.LastName.ToLower()
                .StartsWith(input.ToLower()))
               .SelectMany(author => author.Books.Select(x=>x.Title), (author, title) => new

               {
                    Title = title,
                    AuthorFullName=author.FirstName+ " " +author.LastName,

                })
                .ToList();

            var result = string.Join(Environment.NewLine,(authorsBooks2.Select(x => $"{x.Title} ({x.AuthorFullName})")));

            return result;
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            return context.Books.Where(x => x.Title.Length > lengthCheck).Count();    
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors.Select(x => new
            {
                AuthorName = x.FirstName + " " + x.LastName,
                BooksCopiesCount = x.Books.Sum(x => x.Copies)
            })
                .OrderByDescending(x => x.BooksCopiesCount)
                .ToList();

            var result = string.Join(Environment.NewLine, authors.Select(x => $"{x.AuthorName} - {x.BooksCopiesCount}"));

            return result;
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categoriesProfits = context.Categories.Select(x => new
            {
                Name = x.Name,
                Profit = x.CategoryBooks.Sum(x => x.Book.Price * x.Book.Copies)
            })
                .OrderByDescending(x => x.Profit)
                .ThenBy(x => x.Name)
                .ToList();

            var result = string.Join(Environment.NewLine, categoriesProfits.Select(x => $"{x.Name} ${x.Profit:f2}"));

            return result;

        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories.Select(x => new
            {
                Books = x.CategoryBooks
                .Select(x => x.Book)
                .OrderByDescending(x => x.ReleaseDate)
                .Take(3)
                .Select(x => $"{x.Title} ({x.ReleaseDate.Value.Year})")
                .ToList(),

                CategoryName = x.Name


            })
                .OrderBy(x=>x.CategoryName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.CategoryName}");

                foreach (var book in category.Books)
                {
                    sb.AppendLine(book);

                }

            }

            return sb.ToString().Trim();


        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books.Where(x => x.ReleaseDate.Value.Year < 2010).ToList();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var booksToDelete = context.Books.Where(x => x.Copies < 4200).ToList();

            var count = booksToDelete.Count();

            context.Books.RemoveRange(booksToDelete);


            context.SaveChanges();

            return count;
        }


        private static string[] BooksCategories(Book x)
        {
            return x.BookCategories.Select(x => x.Category.Name.ToLower()).ToArray();
        }

        private static bool CheckIfContains(string[] booksCategories, string[] categories)
        {
            foreach (var currentCategory in booksCategories)
            {
                if (categories.Contains(currentCategory))
                {
                    return true;
                }

            }

            return false;
        }


    }
}
