using Factory.Vehicles;

namespace Factory.Factories;

class Bike : IVehicle
{
    public void GetCargo()
    {
        Console.WriteLine("Pegamos a encomenda.");
    }

    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Iniciamos a entrega de bike.");
    }
}