// StartLive(new Youtube());
// StartLive(new Facebook());
// StartLive(new Twitch());
StartAdvancedLive(new Twitch());


static void StartLive(IPlataform plataform)
{
    Live live = new(plataform);
    live.Broadcasting();
    live.Result();
}

static void StartAdvancedLive(IPlataform plataform)
{
    AdvancedLive live = new AdvancedLive(plataform);
    live.Broadcasting();
    live.Subtitles();
    live.Comments();
    live.Result();
}