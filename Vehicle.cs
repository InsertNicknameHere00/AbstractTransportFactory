using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransportFactory
{
    // Интерфейс за превозно средство (част от продукта в шаблона Abstract Factory)
   public interface IVehicle
    {
        public abstract void Drive();
    }
}
