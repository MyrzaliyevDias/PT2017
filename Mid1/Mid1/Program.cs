using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            for (int i = 1; i <= n; ++i)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
                Console.ReadLine(); 
            }
        }
    }
}