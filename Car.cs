using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransportFactory
{
    // Конкретен продукт - кола (Concrete Product в шаблона Abstract Factory)
    public class Car : IVehicle
    {
        public string brand { get { return "McDonal Douglas"; } }
        public string model { get { return "CBT-16"; } }
        public string seatNum { get { return "5"; } }
        public string seatPrice { get { return "4"; } }

        public void Drive()
        {
            Console.WriteLine("Driving the bus...");
            Console.WriteLine("The bus's info: " + this.brand + " " + this.model);
        }
    }
}