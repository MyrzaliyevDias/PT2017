using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat_1_2
{
    class Programm
    {
        static void Main()
        {
            student a, b, c;
            a = new student(4.0, "Myrzaliev", "Dias", 18); // используем конструктор для определения
            b = new student(4.0, "Borash", "Kazbek", 18);
            c = new student(4.0, "Seilova", "Zaure", 18);
            Console.WriteLine(a + "\n" + b + "\n" + c); // выводим данные студентов
            Console.ReadKey();
        }
    }

}
