using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            if(input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }

            char[] openning = new char[] { '(', '[', '{' };
            char[] closing = new char[] { ')', ']', '}'};

            var stack = new Stack<char>();
            foreach (var element in input)
            {
                if (openning.Contains(element))
                {
                    stack.Push(element);

                }
                else if (closing.Contains(element))
                {
                    var lastElement = stack.Pop();

                    int openingIndex = Array.IndexOf(openning, lastElement);
                    int closingIndex = Array.IndexOf(closing, element);
                    
                    if (openingIndex != closingIndex)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
            }
            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
