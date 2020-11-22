using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }
        public override string ToString()
        {
            return $"{Title}\n{Pages}\n{Category}\n{Author}\n{ReleaseDate}";
        }
    }
}
        
        

        
        
