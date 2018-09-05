using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Handmaid's Tale", "Margaret Atwood", 10.99, "89207303284");
            Console.WriteLine(book.PrintInformation());
        }
    }
}
