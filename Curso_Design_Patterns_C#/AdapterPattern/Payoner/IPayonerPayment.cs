interface IPayonerPayment
{
    Token Auth();
    void Send();
    void Receive();
}