using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num%2)>0) 
                    {
                Console.WriteLine("Число не четное");

            }
            else
            {
                Console.WriteLine("Число четное");
            }
            Console.ReadLine();
        }
    }
}
