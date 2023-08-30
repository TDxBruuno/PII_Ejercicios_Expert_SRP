using System.Collections.Generic;

namespace SRP
{
    public class LibraryBook
    {
        public Book Book { get; }
        public Sector LibrarySector { get; set; }
        public Shelve LibraryShelve { get; set; }

        public LibraryBook(Book book)
        {
            Book = book;
        }

        public void ShelveBook(Sector sector, Shelve shelve)
        {
            LibrarySector = sector;
            LibraryShelve = shelve;
            sector.AddShelveToSector(shelve);
            shelve.AddBookToShelve(this);
        }

        public void UnshelveBook()
        {
            LibraryShelve?.RemoveBookFromShelve(this);
            LibrarySector?.RemoveShelveFromSector(LibraryShelve);
            LibrarySector = null;
            LibraryShelve = null;
        }
    }
}
