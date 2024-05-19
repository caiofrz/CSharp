
namespace Curso_CSharp_Essentials.exercicios.Fase1;
class Exercicios
{
    public static void Main(string[] args)
    {
        //1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
        short idade = 35;
        Console.WriteLine("" + idade);

        //2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
        string nome = "Maria";
        Console.WriteLine("" + nome);

        //3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
        double altura = 3.45;
        Console.WriteLine("" + altura);

        //4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
        DateTime data = new DateTime(1999, 09, 04);
        Console.WriteLine("" + data);

        //5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
        const short ano = 12;
        Console.WriteLine("" + ano);

        //6- Declare uma variável nota do tipo double como sendo do tipo Nullable type 
        //e atribua o  valor 7.80 e exiba o seu valor.
        Nullable<double> nota = 7.8;
        Console.WriteLine("" + nota);

        //7- Quais as diferenças entre os tipos por valor e os tipos por referência ?
        /*
            Tipo por valor é quando se atribui um valor explicito diretamente para aquela variavel.
            Nesse caso são armazenados os dados reais.

            Tipo por referencia é quando se atribui um tipo complexo como objetos, por exemplo.
            Nesse caso o que fica armazenado é uma referencia aquele objeto na memoria.

            Ex:
            Tipo por valor -> int idade = 35;
            Tipor por referencia -> string nomeCompleto = nome;
        */

        //8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
        //( short ) x = 10; 
        //( double ) numero = 7.99;
        //( char ) letra = 'C'; 
        //( float ) temperatura = 27.4f; 
        //( bool ) ativo = false; 
        //( string ) nome = "Manoel";
        //( decimal ) salario = 950.99m;
        //( DateTime ) hoje = DateTime.Now;

        //9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência (R) :
        //( V ) int n = 1; 
        //( R ) string titulo = "A vida"; 
        //( V ) float f = 12.45f; 
        //( V ) double d = 5.45; 
        //( V ) decimal valor = 10.99m;
        //( V ) char sexo = ‘M’;
        //( R ) object o = null;

        //10- O que é um nullable type e qual a sua utilidade ?
        /*
            Tipos primitivos não aceitam null. São tipos não nulos. 
            Os nullables types vem como uma alternativa a isso.
            É um "objeto", que está ligado a um tipo primitivo 
            fazendo com que aquela variavel declarada como nullable type também possa receer o valor nulo.

            Ex:
            Nullable<string> nomeCompleto = null;   
            
            string nomeCompleto? = null;    

            Verifica se nomeCompleto é nulo, se for, atribui "N/A". Ele permite as duas atribuições.
            string nome = nomeCompleto ?? "N/A";    
        */

        //11- O que é Camel Case ? Dê um exemplo de sua aplicação.
        /*
            Camel Case é uma convenção de nomenclatura bastante difundida na area de programação.
            Essa convenção sugere que se comece a primiera letra da primeira palavra com letra minuscula
            e as demais plavras comecem com letra maiuscula. Normalmente usada para nomes de váriavel no c#.
            Ex: nomeCompleto
        */

        //12- O que é Pascal Case ? Dê um exemplo de sua aplicação.
        /*
            Pascal Case também é uma convenção de nomenclatura, mas não tão difundida quanto a Camel Case.
            A principal lingugaem que adota essa convenção é o C#.
            Essa convenção sugere que a primiera letra de cada palavra seja maiuscula. 
            Normalmente usada para nomes de classe, e no c# para atributos públicos e metodos.
            Ex: Console.WriteLine("");
        */

        /*13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a 
            seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a 
            operação de soma)
        */
        int x = 77;
        int y = 66;
        int soma = x + y;
        Console.WriteLine("" + soma);

        //14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
        /*
            bool -> false
            char -> \x0000\
            int -> 0
            double -> 0.0
            float -> 0.0f
            decimal -> 0.0m
            string -> null
        */

        //15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada:
        /*
        ( F ) double 1valor = 12.45; 
        ( F ) string #nome = "Pedro"; 
        ( V ) float _temperatura = 12.45f; 
        ( V ) double int = 5; 
        ( F ) decimal renda extra = 91.45m;
        ( F ) bool status$conta = false;
        ( V ) string titulo3 = “Tópico 1”; 
        ( V ) float salario_mensal = 1999.55f;
        ( V ) int percentualValorDesconto = 5;
        ( V ) const bool MENSALIDADE_EM_DIA = true
        */
    }
}