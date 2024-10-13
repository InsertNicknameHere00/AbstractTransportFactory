using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTransportFactory
{
        // Concrete Product: Land Transport Ticket
        public class LandTransportTicket : Car, ITicket
        {
        public void Book()
        {
            Console.WriteLine("Booking a land transport ticket...");
            Console.WriteLine("The bus's info: " + this.brand + " " + this.model + " " + "\n The ticket info: " + "Seat number: " + this.seatNum + " " + "Seat price: " + this.seatPrice);
        }
    }
}