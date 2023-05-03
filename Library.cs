namespace Bibliotek
{
    public class Library
    {
        private readonly List<Book> _notLended;
        private readonly List<Book> _lendedExpired;
        private readonly List<Book> _lendedNotExpired;
        public Library()
        {
            _notLended = new List<Book>();
            _lendedExpired = new List<Book>();
            _lendedNotExpired = new List<Book>();
        }
        public void AddBook(string name, int lendingTime)
        {
            var book = new Book(name, lendingTime);
            _notLended.Add(book);
        }

    }
}
