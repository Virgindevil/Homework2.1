using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Person
    {
        private string Fname; // Переменная Имени
        private string Lname; // Переменная Фамилии
        private string Aname; // переменная Отчества
        private int Age; // Переменная Возраста
        private string Email; // Переменная Роста
        private float History; // Переменная Баллов по Истории
        private float Math; // Переменная Баллов по Математике
        private float Rus; // Переменная Баллов по Русскому        

        public Person()
        {
            
        } // Профиль ученика

        public void AddFName(string fname) // Данные Имени
        {
            Fname = fname;
        }

        public void AddLName(string lname) // Данные Фамилии
        {
            Lname = lname;
        }

        public void AddAName(string aname)  // Данные Отчества
        {
            Aname = aname;
        }

        public void AddAge(int age) // Данные Возраста
        {
            Age = age;
        } 

        public void AddHeight(string height) // Данные Роста
        {
            Email = height;
        }

        public void AddHistory(float history) // Данные Баллов по Истории
        {
            
            History = history;
        }

        public void AddMath(float math) // Данные Баллов по Математике
        {
            
            Math = math;
        }

        public void AddRus(float rus) // Данные Баллов по Русскому
        {           
            Rus = rus;           

        }
        public void ShowPerson()
        {            
            Console.WriteLine($"{Fname,10} {Lname,15} {Aname,15} {Age,7} {Email,21} {History,10} {Math,7} {Rus,8}");

        }
    }
}