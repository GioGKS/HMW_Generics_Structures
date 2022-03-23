using System;
using System.Collections.Generic;
using System.Text.Json;

namespace HMW_Generics_Structures
{
    public class Book
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }


        public Book()
        {
        }

        public Book(string title,string content,string author,string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
