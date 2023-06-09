﻿namespace RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n  = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcFactorialRecursively(n));
        }

        private static int CalcFactorialRecursively(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalcFactorialRecursively(n - 1);
        }
    }
}