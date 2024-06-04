using Factory.Vehicles;

namespace Factory.Factories;

abstract class TransportFactory
{
    public void StartTransport()
    {
        IVehicle vehicle = Create();
        vehicle.StartRoute();
    }

    protected abstract IVehicle Create();
}
