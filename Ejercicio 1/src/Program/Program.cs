using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un libro
            Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "123456");

            // Crear un estante
            Shelve shelve = new Shelve("Fiction");

            // Crear un sector
            Sector sector = new Sector("Library East Wing");

            // Crear un libro de biblioteca y ubicarlo en un estante y sector
            LibraryBook libraryBook = new LibraryBook(book);
            libraryBook.ShelveBook(sector, shelve);

            // Mostrar información
            Console.WriteLine("Book Title: " + libraryBook.Book.Title);
            Console.WriteLine("Author: " + libraryBook.Book.Author);
            Console.WriteLine("Code: " + libraryBook.Book.Code);
            Console.WriteLine("Shelve: " + libraryBook.LibraryShelve.Name);
            Console.WriteLine("Sector: " + libraryBook.LibrarySector.Name);

            // Desubicar el libro
            libraryBook.UnshelveBook();

            // Mostrar información después de desubicar
            Console.WriteLine("Book Title after unshelving: " + libraryBook.Book.Title);
            Console.WriteLine("Shelve after unshelving: " + (libraryBook.LibraryShelve?.Name ?? "Not shelved"));
            Console.WriteLine("Sector after unshelving: " + (libraryBook.LibrarySector?.Name ?? "Not shelved"));
        }
    }
}
