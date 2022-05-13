using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Из консоли ввести строку, вывести её побуквенно
            
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
