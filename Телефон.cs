using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp6
{
    internal class Телефон
    {
        public string Name { get; set; }
        public int Zaryadka { get; set; }
        public bool Sim { get; set; }
        public string Nomer { get; set; }
        public Телефон()
        {

        }
        public Телефон(string name, int zaryadka, bool sim)
        {
            Name = "Xiaomi";
            Zaryadka = 80;
            Sim = true;

        }
        public void MakeACall(string number)
        {
            
               Console.WriteLine("Введіть номер телефону:");
                Console.ReadLine();

            if (Zaryadka >= 5  )
            {
  
                throw new NotImplementedException("Не вистачає зарядки");
            }
             if ( Sim != true)
            {
                throw new NotImplementedException("Нема карти");
            }
            if ( Nomer.Length == 13 && Nomer.StartsWith("+380"))
            {
                throw new NotImplementedException("Невірний формат номера телефону");
            } else
            {
                Console.WriteLine("Успішний дзвінок");
            }
        }

    }
}
