namespace Bibliotek
{
    public class Book
    {
        private string _title;
        private int _lendingTime;
        public Book(string title, int lendingTime)
        {
            _title = title;
            _lendingTime = lendingTime;
        }
    }
}
