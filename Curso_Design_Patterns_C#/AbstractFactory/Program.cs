
using AbstractFactory;
using AbstractFactory.Factories;

App app = ConfigureApp("uber");
app.Init();



static App ConfigureApp(string company)
{
    ITransportFactory transportFactory;

    transportFactory = company switch
    {
        "uber" => new UberFactory(),
        "99" => new NineNineFactory(),
    };

    return new App(transportFactory);
}