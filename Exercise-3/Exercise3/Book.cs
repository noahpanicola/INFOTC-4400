using System;


namespace Exercise3 {

    public class Book {

        string title, author, isbn;
        double price;

        public Book(string title, string author, double price, string isbn) {
            this.title = title;
            this.author = author;
            this.price = price;
            this.isbn = isbn;
        }

        public string PrintInformation() {
            return (
                title + " written by " +
                author + " is " + price +
                " with ISBN " + isbn
            );
        }

        public string Title {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Isbn {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public double Price { 
            get { return this.price; } 
            set { this.price = value; } 
        }

    }

}
