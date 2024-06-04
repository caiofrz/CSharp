class Live : ITransmissions
{
    protected IPlataform plataform;

    public Live(IPlataform plataform)
    {
        this.plataform = plataform;
    }

    public void Broadcasting()
    {
        Console.WriteLine($"Iniciando live na {plataform.ToString()}");
    }

    public void Result()
    {
        Console.WriteLine("AO VIVO");
    }
}