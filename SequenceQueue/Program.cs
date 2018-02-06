using System;
using System.Collections.Generic;

namespace SequenceQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = long.Parse(Console.ReadLine());

            var sequence = new Queue<long>();
            sequence.Enqueue(input);

            var currentNumber = new Queue<long>();

            while(sequence.Count < 50)
            {
                sequence.Enqueue(input + 1);
                currentNumber.Enqueue(input + 1);

                if(sequence.Count < 50)
                {
                    sequence.Enqueue(2 * input + 1);
                    currentNumber.Enqueue(2 * input + 1);
                }
                if(sequence.Count < 50)
                {
                    sequence.Enqueue(input + 2);
                    currentNumber.Enqueue(input + 2);
                    input = currentNumber.Dequeue();
                }
            }
            Console.WriteLine(string.Join(" ", sequence));
           
        }
    }
}
