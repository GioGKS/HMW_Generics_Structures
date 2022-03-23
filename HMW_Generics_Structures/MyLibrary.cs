using System;
using System.Collections.Generic;
using System.Text.Json;

namespace HMW_Generics_Structures
{
    public class MyLibrary
    {
        private Dictionary<string, Book> books;


        public int Count { get => books.Count; }

        public MyLibrary()
        {
        }

        public bool AddBook(string key,Book book)
        {
            if (book == null)
                return false;
            return true;
        }

        public void Removebook(string book)
        {
            books.Remove(book);
            
        }

        public bool HavethisBook(string book2)
        {
            if (book2 != null)
                return true;
            return false;
        }

        public Book GetBook(string book3)
        {
            return books[book3];
        }

        public string GetBookByAuthor(Book value)
        {
            return value.Author;
        }

        public void Clear()
        {
            books = new Dictionary<string, Book>();
        }

        public List<string> GetAuthors(List<string> author)
        {
            foreach (var names in author)
            {
               
            }
            return author;

        }


        public List<string> GetAllAuthors()
        {
            List<string> authors = new List<string>();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }

            return authors;
        }

    }
}
