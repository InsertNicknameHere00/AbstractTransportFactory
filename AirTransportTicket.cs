using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransportFactory
{
        // Concrete Product: Air Transport Ticket
        public class AirTransportTicket : Airplane, ITicket
        {
            public void Book()
            {
                Console.WriteLine("Booking an air transport ticket...");
            Console.WriteLine("The airplane's info: " + this.brand + " " + this.model + " " + "\n The ticket info: " + "Seat number: " + this.seatNum + " " + "Seat price: " + this.seatPrice);
        }
        }
    }