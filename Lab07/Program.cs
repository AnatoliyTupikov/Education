using System.IO;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetBook("1984", "George Orwell", 1999, 320);

            Book book2 = new Book();
            book2.SetBook("Idiot", "Feodor Dostoevskiy", 2017, 536);

            Book book3 = new Book();
            book3.SetBook("Animal Farm: A Fairy Story", "George Orwell", 2021, 112);

            Book book4 = new Book();
            book4.SetBook("A Farewell to Arms", "Hemingway Ernest", 2004, 294);

            Book book5 = new Book();
            book5.SetBook("The Marstian", "Andy Weir", 2024, 512);

            Book[] books = [book1, book2, book3, book4, book5];

            Array.Sort(books);

            foreach (Book book in books) book.PrintBook();
        }
    }
}
