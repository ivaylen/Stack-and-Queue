using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations % array.Length; i++) // 20000000 procentnoto delenie vrashta pak 5pati primerno ako sa 5 chisla rotaciq
            {
                string temp = array[array.Length - 1];

                for (int j = array.Length - 1; j >= 1; j--)
                {
                    array[j] = array[j - 1];
                }
            
            array[0] = temp;
        }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
