using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводиться из консоли 2 числа, вывести сумму
            static int Func()
            {
                // явное преобразование Parse
               int x = int.Parse(Console.ReadLine());
                    return x;
            }

            var firstNum = Func();
            var secondNum = Func(); 
            Console.WriteLine(firstNum + secondNum);
        }
    }
}
