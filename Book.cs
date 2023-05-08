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
        }
        public void RegisterLoan(Lender lender, DateTime date)
        {
            IsLended = true;
            _dateLended = date;
            Lender = lender;
            lender.LendersBooks.Add(this);
        }
        public void ShowName()
        {
            Console.WriteLine(_title);
        }
        public void ShowExpire()
        {
            Console.WriteLine(_dateLended.AddDays(_lendingTime));
        }
        public bool IsExpired()
        {
            if (!IsLended) return false;
            var theDay = DateTime.Now;
            int compare = DateTime.Compare(_dateLended, theDay.AddDays(-_lendingTime));
            return compare == -1;
        }
        public void ShowLenderAndDeadline()
        {
            Console.WriteLine(_title);
            Lender.ShowName();
            ShowExpire();
        }


    }
}
