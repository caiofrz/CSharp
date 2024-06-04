namespace AbstractFactory.Aircrafts;

class Helicopter : IAircraft
{
     public void CheckWind()
    {
        Console.WriteLine("Verificando ventos...");
    }

    public void GetCargo()
    {
        Console.WriteLine("Passageiros a bordo.");
    }

    public void StartRoute()
    {
        GetCargo();
        CheckWind();
        Console.WriteLine("Iniciando decolagem...");
    }
}