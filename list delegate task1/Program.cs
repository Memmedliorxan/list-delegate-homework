using list_delegate_task1.models;
using System;
using System.Collections.Generic;

namespace list_delegate_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook("Titanic", "Home alone", 110);
            library.AddBook("Animal", "Vuqar", 100);
            library.AddBook("History", "Aydin", 350);
            library.AddBook("Physics", "samir", 170);
            library.AddBook("Hello", "Nadir", 75);
            //library.GetBook();
            //library.RemoveByNo("Ti1");
            //library.RemoveAllBookByName("Hello");
            //library.GetBook();
            //ShowBook(library.SearchBooks("Animal"));
            //ShowBook(library.FindAllBooksByPageCountRange(70, 110));
        }
        static void ShowBook(List<Book> books)
        {
            foreach (var item in books)
            {
                Console.WriteLine("----------");
                Console.WriteLine(item);
                Console.WriteLine("----------");
            }

        }
    }
}
