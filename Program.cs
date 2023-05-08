namespace Bibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            var blablaBook = library.AddBook("Bla bla bla", 14); // 14 er lånetid
            var abcBook = library.AddBook("Abc", 10);
            var xyzBook = library.AddBook("Xyz", 20);
            var per = library.AddLender("Per");
            var pål = library.AddLender("Pål");

            abcBook.RegisterLoan(per, DateTime.Now.AddDays(-15));
            blablaBook.RegisterLoan(pål, DateTime.Now.AddDays(-5));

            library.ShowNotLended();
            library.ShowLendedExpired();
            library.ShowLendedNotExpired();

            per.ShowBooksAndDeadlines();

            blablaBook.ShowLenderAndDeadline();
        }
    }
}