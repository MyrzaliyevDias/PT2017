using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numbers:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool prime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                }
            }
            if (prime == false)
            {
                Console.WriteLine(num + " " + "is Not a prime");
            }
            else if (prime == true)
            {
                Console.WriteLine(num + " " + "is a prime");
            }
            Console.ReadLine();

        }
    }
}   


