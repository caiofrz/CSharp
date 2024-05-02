using ProjetoPOO.Services;

namespace ProjetoPOO.Models.Accounts;

class SavingAccount : Account
{
    public SavingAccount(Customer Customer) : base(Customer)
    {
    }
    public SavingAccount(Customer Customer, uint accountNumber) : base(Customer, accountNumber)
    {
    }

    public override void Deposit(double Value)
    {
        base.Deposit(Value * 1.05);
    }
}