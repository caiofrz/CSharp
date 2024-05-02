using System.Text;
using ProjetoPOO.Enums;
using ProjetoPOO.Models;

namespace ProjetoPOO.Services;

class FileService
{
    private string filePath = @"C:\Users\caguiar\Documents\Curso_C#_Básico\ProjetoPOO\Statement.txt";
    public void saveTransaction(Transaction Transaction)
    {
        try
        {
            StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8);
            sw.WriteLine(Transaction.ToString());
            sw.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }

    public void readTransactions()
    {
        string line;
        try
        {
            StreamReader sr = new StreamReader(filePath);
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }

    public Transaction getLastTransaction()
    {
        string line;
        string lastLine = null;
        Transaction lastTransaction = null;
        try
        {
            StreamReader sr = new StreamReader(filePath);
            
                while ((line = sr.ReadLine()) != null)
                {
                    lastLine = line;
                }
            

            string[] transactionInfos = lastLine.Split(",");
            TransactionTypesEnum type;
            Enum.TryParse(transactionInfos[1], out type);
            
            lastTransaction = new Transaction(
               Convert.ToDateTime(transactionInfos[0]),
               Convert.ToDouble(transactionInfos[2]),
               type,
               Convert.ToDouble(transactionInfos[3])
           );
           sr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        return lastTransaction;
    }
}