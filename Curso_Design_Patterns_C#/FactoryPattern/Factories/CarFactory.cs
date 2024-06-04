using Factory.Vehicles;

namespace Factory.Factories;

class CarFactory : TransportFactory
{
    protected override IVehicle Create()
    {
        return new Car();
    }
}
