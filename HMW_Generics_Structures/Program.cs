using System;
using System.Collections.Generic;

namespace HMW_Generics_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> books = new Dictionary<string, Book>();
            books.Add("Book1", new Book
            { Author = "Sherlock Holmes", Category = "Detective", Content = "Be different than your competition.", Title = "Mask Off" });

            books.Add("Book2", new Book
            { Author = "Agatha Christ", Category = "Detective", Content = "Answer questions or solve problems.", Title = "Keep It Going" });

            books.Add("Book3", new Book
            { Author = "Jiul Vern", Category = "Entertainment", Content = "Allow them to relate to what you have written", Title = "80Km Into the Deep" });

            

        }
    }
}
