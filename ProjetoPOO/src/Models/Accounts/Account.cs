
using ProjetoPOO.Enums;
using ProjetoPOO.Services;

namespace ProjetoPOO.Models.Accounts;

class Account
{
    public uint Number { get; }
    public Double Balance { get; set; }
    private uint BranchBank { get; }
    private Customer Customer { get; }

    protected static FileService FileService = new FileService();

    public Account(Customer Customer)
    {
        this.Number = (uint)new Random().Next();
        this.Balance = 0.0;
        this.BranchBank = (uint)new Random().Next();
        this.Customer = Customer;
    }
    public Account(Customer Customer, uint accountNumber)
    {
        this.Number = accountNumber;
        this.Balance = 0.0;
        this.BranchBank = (uint)new Random().Next();
        this.Customer = Customer;
    }

    public virtual void Deposit(Double Value)
    {
        this.verifyTrasaction(Value, TransactionTypesEnum.DEPOSIT);
        this.Balance += Value;

        Transaction transaction = new(DateTime.Now, Value, TransactionTypesEnum.DEPOSIT, this.Balance);
        FileService.saveTransaction(transaction);
    }

    public void Withdraw(Double Value)
    {
        this.verifyTrasaction(Value, TransactionTypesEnum.WITHDRAW);
        this.Balance -= Value;

        Transaction transaction = new(DateTime.Now, Value, TransactionTypesEnum.WITHDRAW, this.Balance);
        FileService.saveTransaction(transaction);
    }

    public void Transfer(Account TargetAccount, Double Value)
    {
        this.verifyTrasaction(Value, TransactionTypesEnum.TRANSFER);
        this.Balance -= Value;
        TargetAccount.Balance += Value;

        Transaction transaction = new(DateTime.Now, Value, TransactionTypesEnum.TRANSFER, this.Balance);
        FileService.saveTransaction(transaction);
    }

    private void verifyTrasaction(Double Value, TransactionTypesEnum TransactionType)
    {
        if (Value <= 0.0)
        {
            throw new Exception($"Valor inválido!!! O valor para movimentações dever ser maio que 0(zero)");
        }

        if (this.Balance < Value && TransactionType != TransactionTypesEnum.DEPOSIT)
        {
            throw new Exception($"Saldo insuficiente!!! Saldo disponivel para movimentações: {this.Balance}");
        }
    }

    public void showStatement()
    {
        FileService.readTransactions();
    }

    public Transaction getLastTransaction(){
        return FileService.getLastTransaction();
    }
}