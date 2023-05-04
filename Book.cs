namespace Bibliotek
{
    public class Book
    {
        private string _title;
        private int _lendingTime;
        private bool _isLended;
        public Lender Lender { get; set; }
        private DateTime _dateLended;


        public Book(string title, int lendingTime)
        {
            _title = title;
            _lendingTime = lendingTime;
            _isLended = false;
            Lender = null;
        }
        public void RegisterLoan(Lender lender, DateTime date)
        {
            _isLended = true;
            Lender = lender;
            _dateLended = date;
        }
    }
}
