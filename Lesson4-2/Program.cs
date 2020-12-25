using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку чисел");
            string strNum = Console.ReadLine();
            String[] words = strNum.Split(' ');
            int sum=0;
            
            for (int i = 0; i < words.Length; i++)
            {
                sum = sum+Convert.ToInt32(words[i]);
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }

    }
}
