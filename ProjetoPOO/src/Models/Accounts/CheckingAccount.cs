namespace ProjetoPOO.Models.Accounts;

class CheckingAccount : Account
{
    public CheckingAccount(Customer Customer) : base(Customer)
    {
    }
    public CheckingAccount(Customer Customer, uint accountNumber) : base(Customer, accountNumber)
    {
    }

    public override void Deposit(Double Value)
    {
        base.Deposit(Value * 1.01);
    }
}