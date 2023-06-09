﻿namespace Bibliotek
{
    public class Library
    {
        private readonly List<Book> _notLended;
        private readonly List<Book> _lendedExpired;
        private readonly List<Book> _lendedNotExpired;
        private readonly List<Book> _books;
        public Library()
        {
            _notLended = new List<Book>();
            _lendedExpired = new List<Book>();
            _lendedNotExpired = new List<Book>();
            _books = new List<Book>();
        }
        public Book AddBook(string name, int lendingTime)
        {
            var book = new Book(name, lendingTime);
            _books.Add(book);
            return book;
        }
        public Lender AddLender(string name)
        {
            var lender = new Lender(name);
            return lender;
        }
        //public void ShowNotLended()
        //{
        //    _notLended.Clear();
        //    foreach (var book in _books)
        //    {
        //        if (!book.IsLended)
        //        {
        //            _notLended.Add(book);
        //        }
        //    }
        //    Console.WriteLine("Ulånte bøker:");
        //    foreach (var book in _notLended)
        //    {
        //        book.ShowName();
        //    }
        //    Console.WriteLine();

        //}
        //public void ShowLendedExpired()
        //{
        //    _lendedExpired.Clear();
        //    foreach (var book in _books)
        //    {
        //        if (book.IsExpired())
        //        {
        //            _lendedExpired.Add(book);
        //        }
        //    }
        //    Console.WriteLine("Lånte bøker som har gått utover fristen:");
        //    foreach (var book in _lendedExpired)
        //    {
        //        book.ShowName();
        //    }
        //    Console.WriteLine();
        //}
        //public void ShowLendedNotExpired()
        //{
        //    _lendedNotExpired.Clear();
        //    foreach (var book in _books)
        //    {
        //        if (book.IsLended && !book.IsExpired())
        //        {
        //            _lendedNotExpired.Add(book);
        //        }

        //    }
        //    Console.WriteLine("Lånte bøker som ikke har gått utover fristen:");
        //    foreach (var book in _lendedNotExpired)
        //    {
        //        book.ShowName();
        //    }
        //    Console.WriteLine();
        //}

        public void ShowIfLended(bool notLended, bool expired, bool notExpired)
        {
            if (notExpired)
            {
                _lendedNotExpired.Clear();
                foreach (var book in _books)
                {
                    if (book.IsLended && !book.IsExpired())
                    {
                        _lendedNotExpired.Add(book);
                    }

                }
                Console.WriteLine("Lånte bøker som ikke har gått utover fristen:");
                listBooks(_lendedNotExpired);
            }
            if (expired)
            {
                _lendedExpired.Clear();
                foreach (var book in _books)
                {
                    if (book.IsExpired())
                    {
                        _lendedExpired.Add(book);
                    }
                }
                Console.WriteLine("Lånte bøker som har gått utover fristen:");
                listBooks(_lendedExpired);
            }
            if (notLended)
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
                listBooks(_notLended);
            }
        }
        private void listBooks(List<Book> list)
        {
            foreach (var book in list)
            {
                book.ShowName();
            }
            Console.WriteLine();
        }

    }
}
