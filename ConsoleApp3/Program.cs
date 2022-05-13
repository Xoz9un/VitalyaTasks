using System;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Выводить длину введённой в консоль строки. Подсказка, в картинке

            var str = Console.ReadLine();
            Console.WriteLine(str.Length);
            
                //интересно было сделать
            if (str.Contains(' ')) 
            {
                Console.WriteLine(false);
            }
            else { Console.WriteLine(true); }

            Console.WriteLine(str.Replace(str, "Vlad"));

        }
    }
}
