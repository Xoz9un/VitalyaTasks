using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сделать тоже самое через foreach. Интернет в помощь

            string name = Console.ReadLine();

            foreach (var symbols in name)
            {
                Console.WriteLine(symbols);
            }
        }
    }
}
