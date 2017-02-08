using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat_1_2
{
    class student
    {
        // Храним 4 значения для каждого студента
        // их средний балл, имя, фамилия и возраст
        double gpa;
        string name, surname;
        int age;
        //конструктор принимающий значения
        public student(double _gpa, string family_name, string first_name, int _age)
        {
            gpa = _gpa;
            name = first_name;
            surname = family_name;
            age = _age;
        }
        //     |переписанный| метод
        public   override       string ToString()
        {
            //форматированный вывод данных студента
            return "Student: " + name + " " + surname + " at the age of " + age + " has GPA " + gpa;
        }
    }

}
