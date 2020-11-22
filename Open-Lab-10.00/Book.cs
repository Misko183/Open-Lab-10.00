using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        public string Title { get; set; } 
        private int Pages { get; set; } 

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }
    }
}
