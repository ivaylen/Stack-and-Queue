using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
                var stack = new Stack<int>();

                foreach (var item in input)
                {
                    stack.Push(item);
                }
                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop() + " ");
                }        
        }
    }
}
