class Ex11
{
    public static void main(String[] args)
    {
        //11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
        // console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(x % 2 == 0 ? "Par" : "Impar");
        Console.WriteLine(y % 2 == 0 ? "Par" : "Impar");
    }
}