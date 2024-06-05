class CheckPermissionMiddleware : Middleware
{
    public override bool Check(string email, string password)
    {
        if (email.Equals("caio@teste.com"))
        {
            Console.WriteLine("Seja bem-vindo administrador.");
            return true;
        }

        Console.WriteLine("Seja bem-vindo!");

        return CheckNext(email, password);
    }
}
