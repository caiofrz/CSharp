class Program
{
    private static Server server;

    static void Main(string[] args)
    {
        Init();

        bool done = false;

        do
        {
            Console.WriteLine("Digite o seu e-mail:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a sua senha:");
            string password = Console.ReadLine();

            done = server.LogIn(email, password);

        } while (!done);

        Console.ReadKey();
    }

    static void Init()
    {
        server = new Server();
        server.RegisterUser("caio@teste.com", "#123123@%$");
        server.RegisterUser("teste@teste.com", "123456");

        Middleware middleware = new CheckUserMiddleware(server);

        middleware.LinkWith(new CheckPermissionMiddleware());
        middleware.LinkWith(new CheckWeakPassword());

        server.SetMiddleware(middleware);
    }
}