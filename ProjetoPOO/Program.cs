
using ProjetoPOO.Enums;
using ProjetoPOO.Models;
using ProjetoPOO.Models.Accounts;
using ProjetoPOO.UI;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank("NovoBanco", new Address("Rua 1", 1, "Centro", 39930000));
        Customer newCustomer = new Customer("Caio", "11111111111", "caio@teste.com");
        Customer newCustomer2 = new Customer("Teste", "11111111112", "teste@teste.com");

        Account caioAccount = bank.createAccount(newCustomer, AccountTypesEnum.SAVING);
        Account testAccount = bank.createAccount(newCustomer2, AccountTypesEnum.CHECKING);
        Account test2Account = bank.createAccount(newCustomer2, AccountTypesEnum.SAVING, 1);

        var lastTransaction = caioAccount.getLastTransaction();
        // Console.WriteLine("" + lastTransaction);
        // Console.ReadKey();
        if (lastTransaction == null)
        {
            caioAccount.Deposit(1000.00);
        } else {
            caioAccount.Balance = lastTransaction.FinalBalance;
        }

        BankUI.showPresentation();
        ushort operation = 9;

        while (operation != 0)
        {
            BankUI.showMenuOptions();
            try
            {
                operation = Convert.ToUInt16(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        BankUI.Deposit(caioAccount);
                        break;
                    case 2:
                        BankUI.Withdraw(caioAccount);
                        break;
                    case 3:
                        BankUI.Transfer(bank, caioAccount);
                        break;
                    case 4:
                        BankUI.ShowBalance(caioAccount);
                        break;
                    case 5:
                        BankUI.PrintStatement(caioAccount);
                        break;
                    case 0:
                        operation = 0;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Erro ao realizar operação: {ex.Message}");
            }
            continue;
        }
    }
};