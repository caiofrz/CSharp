namespace AbstractFactory.LandVehicles;
class Car : ILandVehicle
{
    public void GetCargo()
    {
        Console.WriteLine("Pegamos os passageiros.");
    }

    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Iniciamos oa viagem.");
    }
}