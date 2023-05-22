using System;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            int count = 40;

            Console.WriteLine("Перші {0} чисел Фібоначчі:", count);
            for (int i = 0; i < count; i++)
            {
                int fibonacciNumber = CalculateFibonacci(i);
                Console.Write(fibonacciNumber + " ");
            }

            Console.ReadLine();
        }

        static int CalculateFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
            }
        }
    }
}
