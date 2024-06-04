class AdvancedLive : Live
{
    public AdvancedLive(IPlataform plataform) : base(plataform)
    {
    }

    public void Subtitles(){
        Console.WriteLine("Legendas ativadas");
    }

    public void Comments(){
        Console.WriteLine("Comentarios ativadas");
    }
}