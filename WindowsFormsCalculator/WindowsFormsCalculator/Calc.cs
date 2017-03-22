using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculator
{
    class Calc
    {
        public double firstnumber;
        public string operation;
        public double result;
        public double secondnumber;

        public void calculate()
        {
            switch (operation)//Рассматриваем случай для каждой операции
            {
                case "+"://Сам случай если операция сложения
                    result = firstnumber + secondnumber;
                    break;
                case "-"://Сам случай если операция вычитание
                    result = firstnumber - secondnumber;
                    break;
                case "*":
                    result = firstnumber * secondnumber;
                    break;
                case "/":
                    result = firstnumber / secondnumber;
                    break;
                case "%":
                    result = firstnumber / 100 * secondnumber;
                    break;
                case "x^2":
                    result = firstnumber * firstnumber;
                    break;
                case "1/x":
                    result = 1 / firstnumber;
                    break;
                case "Sqrt":
                    result = Math.Sqrt(firstnumber);
                    break;
            }

        }
    }
   
}
