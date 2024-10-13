using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransportFactory
{
        // Concrete Factory: Land Transport Factory
        public class LandTransportFactory : TransportFactory
        {
            public override IVehicle CreateVehicle()
            {
                return new Car();
            }

            public override ITicket CreateTicket()
            {
                return new LandTransportTicket();
            }
        }
    }