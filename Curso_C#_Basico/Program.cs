
using DesafioPOO;

class Program
{
    static void Main(string[] args)
    {
        // TiposPrimitivos.main();
        // DesafioEntradaSaida.main();
        try
        {
            Console.WriteLine(Calculadora.somar(2, 2));
            Console.WriteLine(Calculadora.subtrair(2, 2));
            Console.WriteLine(Calculadora.multiplicar(2, 2));
            Console.WriteLine(Calculadora.dividir(2, 2));
            Console.WriteLine(Calculadora.exponenciar(2, 2));
            Console.WriteLine(Calculadora.exponenciar(2, 1));
            Console.WriteLine(Calculadora.dividir(2, 0));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}