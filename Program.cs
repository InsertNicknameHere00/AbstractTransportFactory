using AbstractTransportFactory;

TransportFactory myFactory = new LandTransportFactory();
IVehicle landVehicle = myFactory.CreateVehicle();
ITicket landTicket = myFactory.CreateTicket();

landVehicle.Drive();
landTicket.Book();

Console.WriteLine();

myFactory = new AirTransportFactory();
IVehicle airVehicle = myFactory.CreateVehicle();
ITicket airTicket = myFactory.CreateTicket();

airVehicle.Drive();
airTicket.Book();