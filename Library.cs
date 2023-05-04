namespace Bibliotek
{
    public class Library
    {
        private readonly List<Book> _notLended;
        private readonly List<Book> _lendedExpired;
        private readonly List<Book> _lendedNotExpired;
        public List<Lender> Lenders { get; private set; }
        public Library()
        {
            _notLended = new List<Book>();
            _lendedExpired = new List<Book>();
            _lendedNotExpired = new List<Book>();
        }
        public void AddBook(string name, int lendingTime)
        {
            var book = new Book(name, lendingTime);
        }
        public void AddLender(string name)
        {
            var lender = new Lender(name);
            Lenders.Add(lender);
        }

    }
}
