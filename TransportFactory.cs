using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransportFactory
    {
        // Abstract Factory: Transport Factory
        public abstract class TransportFactory
        {
            public abstract IVehicle CreateVehicle();
            public abstract ITicket CreateTicket();
        }
    }