using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories;

class NineNineFactory : ITransportFactory
{
    public IAircraft CreateTransportAircraft()
    {
        return new Helicopter();
    }

    public ILandVehicle CreateTransportVehicle()
    {
        return new Motorcycle();
    }
}