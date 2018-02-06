using System;
using System.Collections.Generic;

namespace FibonnaciRecursion
{
    public class Program
    {
        private static long[] numbers;

        public static void Main(string[] args)
        {

            /*
            var n = int.Parse(Console.ReadLine());

            numbers = new long[n + 1];

            Console.WriteLine(GetFibo(n));


        }
        private static long GetFibo(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            if(numbers[n] != 0)
            return numbers[n];

            numbers[n] = GetFibo(n - 1) + GetFibo(n - 2);

            return numbers[n];

        }
        */
            var n = int.Parse(Console.ReadLine());
            var currentNumbers = new Stack<ulong>();
            currentNumbers.Push(1);
            currentNumbers.Push(1);

            for (var i = 1; i < n; i++)
            {
                var first = currentNumbers.Pop();
                var second = currentNumbers.Pop();

                currentNumbers.Push(first);
                currentNumbers.Push(first + second);
            }

            currentNumbers.Pop();
            Console.WriteLine(currentNumbers.Peek());
        }
    }
}
