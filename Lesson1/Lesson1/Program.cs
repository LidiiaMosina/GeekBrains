using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            DateTime now = DateTime.Now;
            var date = now.GetDateTimeFormats('d')[0];
            Console.WriteLine($"Hello, {name}, today is {date}!");
            Console.ReadLine();
        }
    }
}
