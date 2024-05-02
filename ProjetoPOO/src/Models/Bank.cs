using ProjetoPOO.Enums;
using ProjetoPOO.Models.Accounts;

namespace ProjetoPOO.Models;

class Bank
{
    private string Name { get; set; }
    public List<Account> Accounts { get; }
    private Address Address { get; set; }

    public Bank(string Name, Address Address)
    {
        this.Name = Name;
        this.Address = Address;
        this.Accounts = new List<Account>();
    }

    public Account createAccount(Customer Customer, AccountTypesEnum AccountType)
    {
        Account NewAccount = AccountType switch
        {
            AccountTypesEnum.CHECKING => new CheckingAccount(Customer),
            AccountTypesEnum.SAVING => new SavingAccount(Customer),
        };
        this.Accounts.Add(NewAccount);
        return NewAccount;
    }
    public Account createAccount(Customer Customer, AccountTypesEnum AccountType, uint accountNumber)
    {
        Account NewAccount = AccountType switch
        {
            AccountTypesEnum.CHECKING => new CheckingAccount(Customer, accountNumber),
            AccountTypesEnum.SAVING => new SavingAccount(Customer, accountNumber),
        };
        this.Accounts.Add(NewAccount);
        return NewAccount;
    }

    public Account findAccount(int accountNumber){
        return this.Accounts.Find(account => account.Number == accountNumber);
    }
}