namespace Bibliotek
{
    public class Book
    {
        private string _title;
        private int _lendingTime;
        public bool IsLended { get; private set; }
        public Lender Lender { get; private set; }
        private DateTime _dateLended;


        public Book(string title, int lendingTime)
        {
            _title = title;
            _lendingTime = lendingTime;
            IsLended = false;
            Lender = null;
        }
        public void RegisterLoan(Lender lender, DateTime date)
        {
            IsLended = true;
            Lender = lender;
            _dateLended = date;
        }
        public void ShowName()
        {
            Console.WriteLine(_title);
        }
        public bool IsExpired()
        {
            DateTime theDay = DateTime.Now;
            if (_dateLended >= theDay.AddDays(-_lendingTime))
            {
                return true;
            }
            else { return false; };
        }
    }
}
