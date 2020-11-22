using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is m1kes, please support me on my Youtube---> m1kes");

            Book LOTR = new Book("Miskove dobrodruzstva", 150,"SCI-FI","Michal Sladecek",2022);

            Console.WriteLine(LOTR.ToString());

           
        }
    }
}
