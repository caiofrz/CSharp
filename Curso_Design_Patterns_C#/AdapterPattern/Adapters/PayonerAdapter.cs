class PayonerAdapter : IPayment
{

    private Payoner payoner;

    public PayonerAdapter(Payoner payoner)
    {
        this.payoner = payoner;
    }

    public Token AuthToken()
    {
        return payoner.Auth();
    }

    public void ReceivePayment()
    {
        payoner.Receive();
    }

    public void SendPayment()
    {
        payoner.Send();
    }
}