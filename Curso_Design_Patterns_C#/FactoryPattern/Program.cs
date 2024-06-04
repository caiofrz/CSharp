using Factory.Factories;

// TransportFactory transport = new CarFactory();
// TransportFactory transport = new MotorcycleFactory();
TransportFactory transport = new BikeFactory();

transport.StartTransport();