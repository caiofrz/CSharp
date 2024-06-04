using Factory.Vehicles;

namespace Factory.Factories;

class BikeFactory : TransportFactory
{
    protected override IVehicle Create()
    {
        return new Bike();
    }
}