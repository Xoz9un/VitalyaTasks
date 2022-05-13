using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Из консоли ввести строку, вывести её четыре раза в цикле
            string str = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(str);
            }
        }
    }
}
