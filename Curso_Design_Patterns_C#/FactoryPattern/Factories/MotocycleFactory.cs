using Factory.Vehicles;

namespace Factory.Factories;

class MotorcycleFactory : TransportFactory
{
    ///
    protected override IVehicle Create()
    {
        return new Motorcycle();
    }
}
