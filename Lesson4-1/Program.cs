using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько пользователей вы хотите ввести?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++) { 
            Console.WriteLine("Введите Фамилию пользователя");
            string userLastName = Console.ReadLine();
            Console.WriteLine("Введите Имя пользователя");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("Введите отчетсво пользователя");
            string userPatronymic = Console.ReadLine();

            Console.WriteLine(GetFullName(userFirstName, userLastName, userPatronymic));
            }
            Console.ReadKey();
        }

    public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string userFullName = lastName + " " + firstName + " " + patronymic;
            return userFullName;
        }
    }
    
}
