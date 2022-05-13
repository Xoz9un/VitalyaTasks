using System;

namespace ConsoleApp2
{
    internal class Program
    {
        // Сделать ввод строк через функцию по аналогии с этим
        static string func()
        {

            string value = (Console.ReadLine());
                return value;
           
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = func();
            Console.Write("Enter your Surname : ");
            var surname = func();
            
            if (name == surname)
            {
                Console.WriteLine("Lox");
            }
            else { Console.WriteLine("Pidr"); }

            Console.WriteLine(name + "\n" + surname);
            
        }
    }
}
