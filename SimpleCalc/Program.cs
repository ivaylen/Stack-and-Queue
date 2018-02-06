using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var n = input[0];
            var s = input[1];
            var x = input[2];

            var integers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var numberStack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                numberStack.Push(integers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numberStack.Pop();
            }

            if(numberStack.Count == 0)
            {
                Console.WriteLine(0);
            }

            else if (numberStack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numberStack.Min());
            }  
        }
    }
}
