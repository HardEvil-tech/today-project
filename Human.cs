using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Human
    {
        public string Name { get; set; }  
        public int Age { get; set; }

        public Human()
        {

        }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Fly()
        {
            throw new NotImplementedException("Ну не можеш ти літати поки що ");
        }
        public void ButWeapon()
        {
            if (Age >= 21)
            {
                Console.WriteLine("Ви купили зброю");
            }
            else
            {
                throw new MemberAccessException("Купляти зброю можна з 21 року");
                    
            }
        } 
    }
}
