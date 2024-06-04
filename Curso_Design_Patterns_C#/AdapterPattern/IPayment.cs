interface IPayment
{
    Token AuthToken();
    void SendPayment();
    void ReceivePayment();
}