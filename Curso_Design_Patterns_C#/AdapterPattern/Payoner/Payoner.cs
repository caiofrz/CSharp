class Payoner : IPayonerPayment
{
    public Token Auth()
    {
        return new Token();
    }

    public void Receive()
    {
        Console.WriteLine("Recebendo pagamento...");
    }

    public void Send()
    {
        Console.WriteLine("Enviando pagamento...");
    }
}