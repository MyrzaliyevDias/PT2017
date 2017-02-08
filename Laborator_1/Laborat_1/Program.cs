using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat_1
{
    class Program
    {
        // Проверка на простоту числа
       static bool check(string number)
        {
            // Перевод в int
            int x = Convert.ToInt32(number);
            int y = 0; // Количество делителей
            for (int i = 1; i <= x; i++)
                if (x % i == 0)
                    y++; //Если делится то это один из делителей
            if (y == 2) return true;    //Если у числа всего два делителя - то это простое число
            else return false;
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < args.Length; i++) //Пробегаемся по числам
            {
                if (check(args[i]))
                {
                    Console.WriteLine(args[i]);
                }
            }
            Console.ReadKey(); //Остановка программы
        }

    }
}
