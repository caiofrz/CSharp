class Youtube : IPlataform
{
    public Youtube()
    {
        ConfigureRMTP();
        Console.WriteLine("Transmissão iniciada...");
    }
    public void AuthToken()
    {
        Console.WriteLine("Token Autorizado");
    }

    public void ConfigureRMTP()
    {
        AuthToken();
        Console.WriteLine("Configrando servidor RMTP...");
    }
}