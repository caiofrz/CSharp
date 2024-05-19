
using System.ComponentModel;

namespace Curso_CSharp_Essentials.exercicios.Fase2;

class Exercicios
{
    public static void Main(string[] args)
    {
        //1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 
        //e exiba a saída no formato : Aluno <nome> tem <idade> anos e nota <nota>
        //usando a concatenação e a interpolação de strings.
        string nome = "Paulo";
        int idade = 17;
        double nota = 7.5;
        Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
        Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

        //2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de 
        //escapes.
        Console.Write(nome + "\n" + idade + "\n" + nota);

        //3- Para qual tipo de dados você pode converter um float implicitamente ?
        /*
            ( ) int 
            (X) double
            ( ) long
            ( ) decimal
        */

        //4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ? 
        /*
            ( ) int para long
            ( ) double para long
            (X) double para float
            ( ) decimal para float
            (X) long para int
            (X) double para decimal
        */

        //5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
        //a concatenação e também a interpolação de string
        char letra1 = Console.ReadKey().KeyChar;
        char letra2 = Console.ReadKey().KeyChar;
        char letra3 = Console.ReadKey().KeyChar;
        Console.WriteLine("");
        Console.WriteLine("" + letra3 + "" + letra2 + "" + letra1);
        Console.WriteLine($"{letra3}{letra2}{letra1}");

        //6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
        /* 
            ( F ) long resultado = 1.32;
            ( V ) var nome = “Maria”;
            ( V ) string resultado = 100.ToString();
            ( V ) A sequência de escape \n inclui uma nova linha
            ( F ) float f = 5.45; 
            ( V ) decimal valor = (decimal) 10.99f;
            ( F ) var status = null;
            ( V ) object o = 12.45m;
            ( V ) string titulo = true.ToString(); 
            ( V ) A sequencia \t inclui uma tabulação vertical
        */

        //7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
        // realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
        // exibindo o resultado:
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine($"soma: {x + y}");
        Console.WriteLine($"subtracao: {x - y}");
        Console.WriteLine($"multiplicação: {x * y}");
        Console.WriteLine($"exponenciação: {Math.Pow(x, y)}");
        Console.WriteLine($"divisão: {x / y}");


        //8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de a b e c .
        //Valores : a = 1 , b = 12 e c = -13
        int a = 1;
        int b = 12;
        int c = -13;
        double delta = Math.Pow(b, 2) - (4 * a * c);
        double x1 = ((b * -1) + Math.Sqrt(delta)) / (2 * a);
        double x2 = ((b * -1) - Math.Sqrt(delta)) / (2 * a);

        //10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando 
        //a nomenclatura usada:
        /*
            ( V ) string? nome; é um exemplo de nullable reference type;
            ( F ) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
            ( V ) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
            ( V ) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
            ( F ) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
            ( F ) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
            ( F ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
            ( F ) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
            ( F ) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
            ( F ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
            ( V ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"
        */

        //14- Escreva um programa que solicite a temperatura em graus Celsius e converta para 
        // Kelvin e Farhenheit usando as fórmulas a seguir:
        // - Converter para Kelvin => K = C + 273 ;
        // - Converter para Farhenheit => F = (C * 9) / 5 + 32 
        double temperaturaEmCelsius = double.Parse(Console.ReadLine());
        double temperaturaEmKelvin = temperaturaEmCelsius + 273;
        double temperaturaEmFarhenheit = temperaturaEmCelsius * 9 / 5 + 32;
        Console.WriteLine(temperaturaEmKelvin);
        Console.WriteLine(temperaturaEmFarhenheit);


        //15 - Escolha a opção que representa a exibição do resultado para o código usando os 
        //         operadores de decremento e incremento(pré e pós) : 
        //         var numero = 5;
        //         Console.WriteLine(numero++);
        //         numero = 1;
        //         Console.WriteLine(++numero);
        //         numero = 2;
        //         Console.WriteLine(numero--);
        //         numero = 3;
        //         Console.WriteLine(--numero);
        //         Console.ReadKey();

        /* 
        (X) 5 2 2 2
        ( ) 6 3 2 2
        ( ) 5 2 1 2
        ( ) 3 2 1 3
        */
    }
}
