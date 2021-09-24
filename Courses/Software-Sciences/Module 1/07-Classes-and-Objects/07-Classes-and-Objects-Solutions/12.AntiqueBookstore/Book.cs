using System;
using System.Collections.Generic;
using System.Text;

namespace AntiqueBookstore
{
    public class Book
    {

        private string title;
        private string author;
        private string publisher;
        private int pubDate;
        private decimal price;
        private string discount;

        public Book(string title, string author, int pubDate, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.PubDate = pubDate;
            this.Price = price;
            this.Publisher = "Unknown";
            this.Discount = "Unavailable";
        }

        public Book(string title, string author, int pubDate, decimal price, string publisher, string discount) 
        {
            this.Title = title;
            this.Author = author;
            this.PubDate = pubDate;
            this.Price = price;
            this.Publisher = publisher;
            this.Discount = discount;
        }
        public Book(string title, string author, int pubDate, decimal price, string publisher)
        {
            this.Title = title;
            this.Author = author;
            this.PubDate = pubDate;
            this.Price = price;
            this.Publisher = publisher;
            this.Discount = "Unavailable";
        }

        public string Discount
        {
            get { return discount; }
            set { discount = value; }
        }


        public int PubDate
        {
            get { return pubDate; }
            set { pubDate = value; }
        }


        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }


        public string Author
        {
            get { return author; }
            set { author = value; }
        }


        public string Title
        {
            get { return title; }
            set { title = value; }
        }


    }
}
