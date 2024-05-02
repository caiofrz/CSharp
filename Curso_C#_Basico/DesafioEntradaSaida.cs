public class DesafioEntradaSaida
{
    public static void main()
    {

        //Ler o nome e idade informados e apresentar junto o calculo do ano em de nscimento

        try
        {
            Console.WriteLine("Informe se nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            int age = int.Parse(Console.ReadLine());

            int currentYear = DateTime.Now.Year;
            int bornYear = currentYear - age;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Idade: {age}");
            Console.WriteLine($"Ano de Nascimento: {bornYear}");
        }
        catch (Exception ex)
        {

            Console.WriteLine("Erro: " + ex.Message);
        }

    }
}