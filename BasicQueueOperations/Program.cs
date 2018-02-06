using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var S = input[1];
            var X = input[2];

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var numQueue = new Queue<int>(numbers);

            for (int i = 0; i < S; i++)
            {
                numQueue.Dequeue();
            }
            if(numQueue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }else if (numQueue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numQueue.Min());
            }
        }
    }
}
