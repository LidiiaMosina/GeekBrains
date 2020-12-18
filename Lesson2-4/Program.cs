using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру ");
            double tmin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите максимальную температуру ");
            double tmax = Convert.ToDouble(Console.ReadLine());
            double tmidle = (tmin + tmax) / 2;
            Console.WriteLine($"Средняя температура {(tmin + tmax) / 2}");

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
            if ((tmidle>0) & (numbMonth == 12 || numbMonth == 1 || numbMonth == 2)){
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                Console.WriteLine($"Обычный {monthTitle}");
            }
            Console.ReadLine();
        }
    }
}
