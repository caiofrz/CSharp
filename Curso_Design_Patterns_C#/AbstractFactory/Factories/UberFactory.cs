using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories;

class UberFactory : ITransportFactory
{
    public IAircraft CreateTransportAircraft()
    {
        return new Airplane();
    }

    public ILandVehicle CreateTransportVehicle()
    {
        return new Car();
    }
}