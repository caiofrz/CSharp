using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory;

class App
{
    private IAircraft aircraft;
    private ILandVehicle vehicle;

    public App(ITransportFactory factory){
        aircraft = factory.CreateTransportAircraft();
        vehicle = factory.CreateTransportVehicle();
    }

    public void Init(){
        aircraft.StartRoute();
        vehicle.StartRoute();
    }
}