using HomeWork13March.Enums;
using HomeWork13March.Exceptions;
using HomeWork13March.Interfaces;
using HomeWork13March.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13March.Services
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }
        public List<Book> Filter(string author, Genre genre)
        {
            return _books.FindAll(books => books.Author == author && books.Genre == genre);
        }
        public List<Book> Search(string value)
        {
            return _books.FindAll(books => books.Author.Contains(value) ||
            books.Genre.ToString().Contains(value) ||
            books.PageCount.ToString().Contains(value) || books.Name.Contains(value));
        }
        public Book ShowInfo(string name)
        {
            Book book = _books.Find(book => book.Name == name);

            if (book != null)
            {
                return book;
            }

            throw new BookNotFoundException($"{name} yoxdur veya tapilmadi");
        }

        public void Add(Book book)
        {
            if (_books.Count > 0 && _books.Exists(b => b.Name == book.Name))
            {
                throw new SameBookalreadyAddedExpection($"{book.Name} elave oluna bilmedi");
            }

            _books.Add(book);

        }
    }
}
