using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }
    }
}
