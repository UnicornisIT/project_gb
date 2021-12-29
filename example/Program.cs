using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива> ");
 
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
        }
    }
}
