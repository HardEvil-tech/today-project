using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Telefon
    {
        public string Name { get; set; }
        public int BatteryCharge { get; set; }
        public bool HasSimCard { get; set; }
        public void Call (string number)
        {
            if (BatteryCharge <= 0)
            {
                throw new ArgumentException("Low BAteery charge");
                if (!HasSimCard)
                    throw new Exception("No sim-card");
                if (!number.StartsWith("+380") || number.Length != 13)
                    throw new ArgumentException("Incorect input number");

                Console.WriteLine("Calling to number" + number);

            }
        }
    }
}
