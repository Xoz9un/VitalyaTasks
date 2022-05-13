using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Посчитать сумму элементов массива

            int[] array = new int[5] {1,4,5,6,7};
            int sumElFor = 0;
            int SumElForeach = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sumElFor = sumElFor + array[i];
                
            }
            Console.WriteLine(sumElFor);


            foreach (int i in array){
                SumElForeach += i;
                
            }
            Console.WriteLine(SumElForeach);
        }
    }
}
