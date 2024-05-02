using ProjetoPOO.Enums;

namespace ProjetoPOO.Models;

class Transaction
{
    private DateTime Timestamps;
    private Double Value;
    private TransactionTypesEnum TransactionType;
    public Double FinalBalance;

    public Transaction(DateTime Timestamps,
                        Double Value,
                        TransactionTypesEnum TransactionType,
                        Double FinalBalance)
    {
        this.Timestamps = Timestamps;
        this.Value = Value;
        this.TransactionType = TransactionType;
        this.FinalBalance = FinalBalance;
    }

    public override string ToString()
    {
        return $"{this.Timestamps},{this.TransactionType},{this.Value},{this.FinalBalance}";
    }

}