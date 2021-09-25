using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntiqueBookstore
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Book> allBooks = new List<Book>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] bookInfo = input.Split(", ");
                string bookTitle = bookInfo[0];
                string bookAuthor = bookInfo[1];
                int bookPubDate = int.Parse(bookInfo[2]);
                decimal bookPrice = decimal.Parse(bookInfo[3]);
                Book book = null;
                if (bookInfo.Length == 6)
                {
                    string bookPublisher = bookInfo[4];
                    string bookDiscount = bookInfo[5];
                    book = new Book(bookTitle, bookAuthor, bookPubDate, bookPrice, bookPublisher, bookDiscount);
                    allBooks.Add(book);
                }
                else if (bookInfo.Length == 5)
                {
                    string bookPublisher = bookInfo[4];
                    book = new Book(bookTitle, bookAuthor, bookPubDate, bookPrice, bookPublisher);
                    allBooks.Add(book);
                }
                else
                {
                    book = new Book(bookTitle, bookAuthor, bookPubDate, bookPrice);
                    allBooks.Add(book);
                }

                input = Console.ReadLine();
            }

            StringBuilder builder = new StringBuilder();
            allBooks = allBooks.OrderBy(x => x.Author).ToList();
            for (int i = 0; i < allBooks.Count; i++)
            {
                Book currentBook = allBooks[i];
                builder.AppendLine($"Title : {currentBook.Title}");
                builder.AppendLine($"   Author: {currentBook.Author}");
                builder.AppendLine($"    Publication Date: {currentBook.PubDate}");
                builder.AppendLine($"    Price: {currentBook.Price}");
                builder.AppendLine($"     Publisher: {currentBook.Publisher}");
                builder.AppendLine($"     Discount: {currentBook.Discount}");
            }

            Console.WriteLine(builder);
        }
    }
}