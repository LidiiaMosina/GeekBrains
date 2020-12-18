using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца ");
            int numbMonth = Convert.ToInt32(Console.ReadLine());
            string monthTitle = "";

            switch (numbMonth)
            {
                case 1:
                    monthTitle = "Январь";
                    break;
                case 2:
                    monthTitle = "Февраль";
                    break;
                case 3:
                    monthTitle = "Март";
                    break;
                case 4:
                    monthTitle = "Апрель";
                    break;
                case 5:
                    monthTitle = "Май";
                    break;
                case 6:
                    monthTitle = "Июнь";
                    break;
                case 7:
                    monthTitle = "Июль";
                    break;
                case 8:
                    monthTitle = "Август";
                    break;
                case 9:
                    monthTitle = "Сентябрь";
                    break;
                case 10:
                    monthTitle = "Октябрь";
                    break;
                case 11:
                    monthTitle = "Ноябрь";
                    break;
                case 12:
                    monthTitle = "Декабрь";
                    break;
            }
            Console.WriteLine($"Это {monthTitle}");
            Console.ReadLine();
        }
    }
}
