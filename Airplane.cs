using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransportFactory
{
    // Конкретен продукт - самолет (Concrete Product в шаблона Abstract Factory)
        public class Airplane : IVehicle
        {
            public string brand { get { return "McDonal Douglas"; } }
        public string model { get { return "CBT-1"; } }
            public string seatNum { get { return "25"; } }
            public string seatPrice { get { return "10"; } }

            public void Drive()
            {
                Console.WriteLine("Flying an airplane...");
                Console.WriteLine("The airplane's info: " + this.brand + " " + this.model);
            }
        }
    }