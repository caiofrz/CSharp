
using ProjetoPOO.Models;
using ProjetoPOO.Models.Accounts;

namespace ProjetoPOO.UI;

class BankUI
{
    public static void showPresentation()
    {
        Console.Clear();
        Console.WriteLine("------------------- Bem Vindo(a) -------------------");
        Console.WriteLine("Esta é uma aplicação para simular as operações básicas de um banco.");
        Console.WriteLine("As operações suportadas são: Deposito, Saque, Transferencia, Ver saldo e Imprimir extrato.");
        Console.WriteLine("Todas as escolhas de operações devem ser feitas através do número correspondente a escolha.");
        Console.WriteLine("Exemplo: \n 1. Operação 1 \n 2. Operação 2");
        Console.WriteLine("Caso a operação desejada seja a \"Operação 1\", digite \"1\", quando for pedido.");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public static void showMenuOptions()
    {
        Console.Clear();
        Console.WriteLine("------------------- Menu -------------------");
        Console.WriteLine("1. Depositar");
        Console.WriteLine("2. Sacar");
        Console.WriteLine("3. Transferir");
        Console.WriteLine("4. Ver saldo");
        Console.WriteLine("5. Imprimir extrato");
        Console.WriteLine("0. Encerrar programa");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Informe o número referente a operação desejada: ");
    }

    public static void Deposit(Account account)
    {
        try
        {

            Console.Clear();
            Console.WriteLine("ATENÇÃO!!!! Somente valores maiores que R$0.0 ");
            Console.WriteLine("Informe o valor a ser depositado: R$ ");
            Double value = Convert.ToDouble(Console.ReadLine());
            account.Deposit(value);
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao realizar operação: {ex.Message}");
            Console.ReadKey();
        }
    }
    public static void Withdraw(Account account)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("ATENÇÃO!!!! Somente valores maiores que R$0.0 ");
            Console.WriteLine("Informe o valor a ser sacado: R$ ");
            Double value = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(value);
            Console.WriteLine("Operação realizada com sucesso!!!");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao realizar operação: {ex.Message}");
            Console.ReadKey();
        }
    }

    public static void Transfer(Bank bank, Account account)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("ATENÇÃO!!!! Somente valores maiores que R$0.0 ");
            Console.WriteLine("Informe o valor a ser transferido: R$ ");
            Double value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o número da conta: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Account TargetAccount = bank.findAccount(accountNumber) ?? throw new Exception("Conta de destino não encontrada");
            account.Transfer(TargetAccount, value);
            Console.WriteLine("Operação realizada com sucesso!!!");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao realizar operação: {ex.Message}");
            Console.ReadKey();
        }
    }

    internal static void ShowBalance(Account account)
    {
        Console.Clear();
        Console.WriteLine($"Saldo: {account.Balance}");
        Console.ReadKey();
    }

    internal static void PrintStatement(Account account)
    {
        account.showStatement();
        Console.ReadKey();
    }
}