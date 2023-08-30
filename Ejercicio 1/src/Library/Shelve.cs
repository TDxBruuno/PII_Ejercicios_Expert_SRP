using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public string Name { get; }
        public List<LibraryBook> BooksOnShelve { get; } = new List<LibraryBook>();

        public Shelve(string name)
        {
            Name = name;
        }

        public void AddBookToShelve(LibraryBook book)
        {
            BooksOnShelve.Add(book);
        }

        public void RemoveBookFromShelve(LibraryBook book)
        {
            BooksOnShelve.Remove(book);
        }
    }
}
