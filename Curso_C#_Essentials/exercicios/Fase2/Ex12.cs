class Ex12
{
    public static void Main(String[] args)
    {
        //12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no 
        // console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)
        // -6 + x * 5
        // (13-2) * x
        // (x + -2) * (20 / x)
        // (12 + x) / (x - 4)
        // 3 x^2 + x + 10
        // pi * x^2

        const double PI = 3.1415;
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(-6 + x * 5);
        Console.WriteLine((13 - 2) * x);
        Console.WriteLine((x + -2) * (20 / x));
        Console.WriteLine((12 + x) / (x - 4));
        Console.WriteLine(3 * Math.Pow(x, 2) + x + 10);
        Console.WriteLine(PI * Math.Pow(x, 2));
    }
}