using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransportFactory
{
        // Concrete Factory: Air Transport Factory
        public class AirTransportFactory : TransportFactory
        {
            public override IVehicle CreateVehicle()
            {
                return new Airplane();
            }

            public override ITicket CreateTicket()
            {
                return new AirTransportTicket();
            }
        }
    }