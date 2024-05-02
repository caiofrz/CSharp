
/// <summary>
/// Classe com tipos primitivos
/// </summary>
class TiposPrimitivos
{
    public static void main()
    {

        //Byte (0 a 255)
        byte meuByte = 1;
        Byte meuByte2 = 2;
        Console.WriteLine(meuByte);
        Console.WriteLine(meuByte2);

        //sbyte (-128 a 127)
        sbyte meuSbyte = -123;
        Console.WriteLine(meuSbyte);

        //short (16 bits)
        short meuShort = 1222;
        Int16 meuShort2 = 1222;
        Console.WriteLine(meuShort);
        Console.WriteLine(meuShort2.Equals(meuShort));
        Console.WriteLine(meuShort2 + meuShort);
        // Console.ReadKey();

        //int (32 bits)
        int meuInt = 10;
        Int32 meuInt2 = 10;
        Console.WriteLine(meuInt);
        Console.WriteLine(meuInt2);

        //long (64 bits)
        long meuLong = 100_000_000;
        Int64 meuLong2 = -100_000_000;
        Console.WriteLine(meuLong);
        Console.WriteLine(meuLong2);

        //uint, ushort, ulong (32 bits)
        // u = unssigned = sem sinal 
        ushort meuUshort = 10;
        uint meuUint = 10;
        ulong meuUlong = 100_000_000;

        //float (32 bits)
        float meuFloat = 10.0f;

        //Decimal (128 bits)
        decimal meuDecimal = 10.0M;

        //double, bool, char, string, object, array seguem padrão

        //constantes
        const int meuConst = 3;

        //Leitura de dados no console
        Console.WriteLine(Console.Read()); // lê a primeria tecla e retorna ASC code
        Console.WriteLine(Console.ReadKey().KeyChar); //lê a unica tecla apertada
        Console.ReadLine(); //lê a string inteira



        //Operadores Lógicos
        // && / ||, se o primeira lado se provar verdadeiro, não executa o outro
        // & / |, sempre executa os dois lados da expressao
        
    }
}