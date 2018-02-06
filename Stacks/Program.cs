using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var item in input)
            {
                stack.Push(item);
            }
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.ReadKey();
        }
    }
}
