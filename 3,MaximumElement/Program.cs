using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var Stack = new Stack<int>();
            var num = long.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var currentNum = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                if(currentNum[0] == 1)
                {
                    var element = currentNum[1];
                    Stack.Push(element);
                }else if(currentNum[0] == 2)
                {
                    Stack.Pop();
                }else if(currentNum[0] == 3)
                {
                    Console.WriteLine(Stack.Max());
                }

            }
            */

            int commandCount = int.Parse(Console.ReadLine());

            var staack = new Stack<int>();
            var maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);

            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        var element = command[1];
                        staack.Push(element);
                        if(element >= maxStack.Peek())
                        {
                            maxStack.Push(element);
                        }
                        break;
                    case 2:
                        var popedElement = staack.Pop();
                        if(maxStack.Peek() == popedElement)
                        {
                            maxStack.Pop();
                        }
                        break;
                    case 3:
                        int maxElement = maxStack.Peek();
                        Console.WriteLine(maxElement);
                        break;
                }
            }
        }
    }
}
