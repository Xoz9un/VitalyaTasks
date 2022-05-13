using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    // Сделать метод, считающий сумму элементов массива.Задача со звёздочкой
    internal class Program
    {
        static int Func(List<int> array)
        {
            int sum = 0;
            
            foreach (int i in array)
            {
                sum += i;

            }
            return sum;
           
        }

        static void Main(string[] args)

        {
         
            var list = new List<int> { 1, 2, 3, 100, 500, 212, 14, 22, 8, 88 };
            var secondList = new List<int> { 10, 5, 5 };
            //linq без хуйни) (чет в последнее время хуйня моё любимое слово)
            var Summa = secondList.Sum(item => item);

            Console.WriteLine(Func(list));
            Console.WriteLine(Summa);


        }

        
    }
}
