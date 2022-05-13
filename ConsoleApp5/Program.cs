using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверить, является ли сумма 2-х введённых чисел больше третьего числа

            static int Func()
            {
                // явное преобразование Parse
                int x = int.Parse(Console.ReadLine());
                return x;
            }

            var firstNum = Func();
            var secondNum = Func();
            var thirdNum = Func();

            var result = firstNum + secondNum;
            if (result > thirdNum)
            {
                Console.WriteLine("Yes, more then result");
            }
            else { Console.WriteLine("No more then result"); }
        }
    }
}
