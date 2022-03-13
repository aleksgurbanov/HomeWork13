using HomeWork13March.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13March.Models
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Genre Genre { get; set; }
        public Book(string name, string author, int pagecount, Genre genre)
        {
            Name = name;
            Author = author;
            PageCount = pagecount;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"Adi: {Name}\n Muellifi: {Author}\n Sehife sayi: {PageCount}\n Janr: {Genre}";
        }
    }
}
