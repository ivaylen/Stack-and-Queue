using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueuesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var inputDec = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            if(inputDec == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (inputDec > 0)
            {
                stack.Push(inputDec % 2);
                inputDec /= 2;
            }
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            */

            var input = Console.ReadLine();
            var stackOpenBrInd = new Stack<int>();

            for (int counter = 0; counter < input.Length; counter++)
            {
                if(input[counter] == '(')
                {
                    stackOpenBrInd.Push(counter);
                }
                if(input[counter] == ')')
                {
                    var openBracketIndex = stackOpenBrInd.Pop();
                    var length = counter - openBracketIndex + 1;
                    Console.WriteLine(input.Substring(openBracketIndex, length));
                 }
            }
        }
    }
}
