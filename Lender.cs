﻿namespace Bibliotek
{
    public class Lender
    {
        private string _name;
        public List<Book> LendersBooks { get; set; }
        public Lender(string name)
        {
            _name = name;
            LendersBooks = new List<Book>();
        }
        public void ShowBooksAndDeadlines()
        {
            Console.WriteLine(_name);
            foreach (var book in LendersBooks)
            {
                book.ShowName();
                book.ShowExpire();
                Console.WriteLine();
            }
        }
        public void ShowName()
        {
            Console.WriteLine(_name);
        }
    }
}
