using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class lowbatteryexecption:Exception
    {
        public Telefon ExceptionTarget  { get; set; }
        public lowbatteryexecption() : base()
        {

        }
        public lowbatteryexecption(string message) : base(message)
        {

        }
        public lowbatteryexecption(string message, Telefon exceptionTarget) : base(message)
        {
            ExceptionTarget = exceptionTarget;
        }
    }
}
