namespace Bibliotek
{
    public class Library
    {
        private readonly List<Book> _notLended;
        private readonly List<Book> _lendedExpired;
        private readonly List<Book> _lendedNotExpired;
        private readonly List<Book> _books;
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
            _books.Add(book);
        }
        public void AddLender(string name)
        {
            var lender = new Lender(name);
            Lenders.Add(lender);
        }
        public void ShowNotLended()
        {
            _notLended.Clear();
            foreach (var book in _books)
            {
                if (!book.IsLended)
                {
                    _notLended.Add(book);
                }
            }
            Console.WriteLine("Ulånte bøker:");
            foreach (var book in _notLended)
            {
                book.ShowName();
            }

        }
        public void ShowLendedExpired()
        {
            _lendedExpired.Clear();
            foreach (var book in _books)
            {
                if (book.IsExpired())
                {
                    _lendedNotExpired.Add(book);
                }
            }
            Console.WriteLine("Lånte bøker som har gått utover fristen:");
            foreach (var book in _lendedExpired)
            {
                book.ShowName();
            }
        }
        public void ShowLendedNotExpired()
        {
            _lendedNotExpired.Clear();
            foreach (var book in _books)
            {
                if (!book.IsExpired())
                {
                    _lendedNotExpired.Add(book);
                }
            }
            Console.WriteLine("Lånte bøker som har gått utover fristen:");
            foreach (var book in _lendedNotExpired)
            {
                book.ShowName();
            }
        }


    }
}
