using HomeWork13March.Enums;
using HomeWork13March.Models;
using HomeWork13March.Services;
using System;

namespace HomeWork13March
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager libraryManager = new LibraryManager();
            do
            {
                Console.WriteLine("1.List Of Books");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Show Book Info ");
                Console.WriteLine("4. Search Book: ");
                Console.WriteLine("5. Filter book");
                Console.WriteLine("6. Exit");
               

                string sechim = Console.ReadLine();
                int sechilen;

                while (!int.TryParse(sechim, out sechilen) || sechilen < 1 || sechilen > 6)
                {
                    Console.WriteLine("Duzgun Secim Edin:");
                    sechim = Console.ReadLine();
                }
                Console.Clear();


                switch (sechilen)
                {
                    case 1:
                        ShowAllBooks(ref libraryManager);
                        break;
                    case 2:

                        AddBook(ref libraryManager);
                        break;

                    case 3:
                        ShowInfo(ref libraryManager);
                        break;
                    case 4:
                        Search(ref libraryManager);
                        break;
                    case 5:
                        Filter(ref libraryManager);
                        break;
                    case 6:
                        break;
                 
                }

            } while (true);
        }
        static void ShowAllBooks(ref LibraryManager libraryManager)
        {
            if (libraryManager.Books != null)
            {
                foreach (var item in libraryManager.Books)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void ShowInfo (ref LibraryManager libraryManager)
        {
            Console.WriteLine("Kitab adini daxil edin");
            string bookname = Console.ReadLine();
            Console.WriteLine($"{libraryManager.ShowInfo(bookname)}");
        }
        static void Search (ref LibraryManager librarymanager)
        {
            Console.WriteLine("kitablara dair bir data daxil et");
            string value = Console.ReadLine();
            foreach (var item in librarymanager.Search(value))
            {
                Console.WriteLine(item);
            }
        }
        static void Filter (ref LibraryManager libraryManager)
        {
            Console.WriteLine("Muellifi qeyd edin");
            string author = Console.ReadLine();
            Console.WriteLine("Novunu qeyd et");
            
            
            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{(int)item} - {item}");
            }
            string choose = Console.ReadLine();
            int genrenum;
           while((!int.TryParse(choose, out genrenum) || genrenum < 1 || genrenum > 3))
            {
                Console.WriteLine("duzgun sechim et");
            }
            Genre genre = (Genre)genrenum;
            foreach (var item in libraryManager.Filter(author,genre))
            {
                Console.WriteLine(item);
            } 
        }
        static void AddBook (ref LibraryManager libraryManager)
        {
            Console.WriteLine("ad daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("muellif daxil edin");
            string author = Console.ReadLine();
            Console.WriteLine("sehife sayi daxil edin");
            string pagecount = Console.ReadLine();
            int.TryParse(pagecount, out int page);
            Console.WriteLine("Novunu qeyd et");


            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{(int)item} - {item}");
            }
            string choose = Console.ReadLine();
            int genrenum;
            while ((!int.TryParse(choose, out genrenum) || genrenum < 1 || genrenum > 3))
            {
                Console.WriteLine("duzgun sechim et");
            }
            Genre genre = (Genre)genrenum;
            Book book = new Book(name, author, page, genre);
            libraryManager.Add(book);
            
        }
    }
 }

