using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            for (int i = greeting.Length-1; i >= 0; i--)
            {
                Console.Write(greeting[i]);
            }
            Console.ReadKey();
        }
    }
}
