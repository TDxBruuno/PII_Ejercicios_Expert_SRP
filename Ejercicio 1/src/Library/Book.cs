namespace SRP
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Code { get; }

        public Book(string title, string author, string code)
        {
            Title = title;
            Author = author;
            Code = code;
        }
    }
}
    