class Paypal : IPayment
{
    public Token AuthToken()
    {
        return new Token();
    }

    public void ReceivePayment()
    {
        Console.WriteLine("Recebendo pagamento...");
    }

    public void SendPayment()
    {
        Console.WriteLine("Enviando pagamento...");
    }
}