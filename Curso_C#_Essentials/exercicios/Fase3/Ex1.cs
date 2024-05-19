using System.Diagnostics.Contracts;

class Ex1
{
    public static void main(String[] args)
    {
        int[] numeros = new int[3];
        int maior = -999999999;
        string? mensagem = null;


        for (int i = 0; i < 3; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] > maior)
            {
                maior = numeros[i];
                mensagem = $"O {++i}° numero: {maior} é o maior";
                i--;
            }
        }
        Console.WriteLine(mensagem);
    }
}