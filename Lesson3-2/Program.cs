using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] person = { { "Иванов", "Петров", "Сидоров", "Каблуков", "Словов" }, { "ivanov@mail.ru", "petrov@mail.ru", "Sidorov@mail.ru", "+79059059999", "+79239459876" } };
            Console.WriteLine("Введите номер контакта ");
            int i = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine($" ФИО: {person[0,i]}, email/телефон {person[1, i]}");
            Console.ReadKey();
        }
    }
}
