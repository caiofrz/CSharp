class Ex9
{
    public static void main(String[] args)
    {
        //9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e 
        // Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ 
        // então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login 
        // inválido’: (use o operador condicional ternário)
        
        string nomeLogin = Console.ReadLine();
        int senhaLogin = int.Parse(Console.ReadLine());
        string mensagem = (nomeLogin == "admin" || nomeLogin == "maria") && senhaLogin == 123 ? "Login feito com sucesso" : "Login inválido";
        Console.WriteLine(mensagem);
    }
}