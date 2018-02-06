using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var indexs = new Stack<int>();
            indexs.Push(0);

            var days = new int[n];

            for (var i = 1; i < n; i++)
            {
                var maxDays = 0;
                while (indexs.Count > 0 && plants[indexs.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[indexs.Pop()]);
                }

                if (indexs.Count > 0)
                {
                    days[i] = maxDays + 1;
                }

                indexs.Push(i);
            }

            Console.WriteLine(days.Max());
        }
    }
}
