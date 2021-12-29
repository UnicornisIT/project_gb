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

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите число> ");
                array[i] = int.Parse(Console.ReadLine());
        }
        
 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    Console.Write($"{array[i]} ");
            }
 
            Console.ReadKey();
        }
    }
}
