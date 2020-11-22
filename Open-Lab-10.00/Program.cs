using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is m1kes, please support me on my Youtube---> m1kes");

            /* Book LOTR = new Book("Miskove dobrodruzstva", 150,"SCI-FI","Michal Sladecek",2020);

             Console.WriteLine(LOTR.ToString());
            */

            /*Console.Write("Name of Book: ");
            string title = Console.ReadLine();

            Console.Write("Pages: ");
            int pages = int.Parse(Console.ReadLine());

            if (pages < 0)
            {
                pages = 1;
            }

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("ReleaseDate: ");
            int releaseDate = int.Parse(Console.ReadLine());

            if (releaseDate < 1450 || releaseDate > 2021)
            {
                releaseDate = -1;
            }

            Book LORT = new Book(title, pages, category, author, releaseDate);

            Console.WriteLine($"{LORT.Title} {LORT.Pages} {LORT.Category} {LORT.Author} {LORT.ReleaseDate}");
            */

            Book LORT2 = new Book();
            Book LORT3 = new Book("Miskove dobrodruzstvo", 150);
            Book HOBIT = new Book("Miskove dobrodruzstva", 150, "SCI-FI", "Michal Sladecek", 2020);

            Console.WriteLine(LORT2.ToString());
            Console.WriteLine(LORT3.ToString());
            Console.WriteLine(HOBIT.ToString());
        }
    }
}
