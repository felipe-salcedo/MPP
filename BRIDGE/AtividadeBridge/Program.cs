using System;

// Interface da Plataforma
interface IPlatform
{
    void AuthToken();
    void ConfigureRMTP();
}

// Implementações concretas

class Facebook : IPlatform
{
    public void AuthToken()
    {
        Console.WriteLine("Facebook: Autorizando aplicação.");
    }

    public void ConfigureRMTP()
    {
        AuthToken();
        Console.WriteLine("Facebook: Configurando servidor RMTP.");
    }
}

class YouTube : IPlatform
{
    public void AuthToken()
    {
        Console.WriteLine("YouTube: Autorizando aplicação.");
    }

    public void ConfigureRMTP()
    {
        AuthToken();
        Console.WriteLine("YouTube: Configurando servidor RMTP.");
    }
}

class Twitch : IPlatform
{
    public void AuthToken()
    {
        Console.WriteLine("Twitch: Autorizando aplicação.");
    }

    public void ConfigureRMTP()
    {
        AuthToken();
        Console.WriteLine("Twitch: Configurando servidor RMTP.");
    }
}

// Abstração: Live

class Live
{
    protected IPlatform platform;

    public Live(IPlatform platform)
    {
        this.platform = platform;
    }

    public virtual void Broadcast()
    {
        Console.WriteLine("Iniciando a transmissão...");
        platform.ConfigureRMTP();
        Console.WriteLine("Transmissão ao vivo iniciada.\n");
    }
}

// Extensão da abstração (opcional)
class AdvancedLive : Live
{
    public AdvancedLive(IPlatform platform) : base(platform) { }

    public void BroadcastWithRecord()
    {
        Broadcast();
        Console.WriteLine("Gravando a live para assistir depois.\n");
    }

    public void EnableSubtitles()
    {
        Console.WriteLine("Ativando legendas ao vivo.\n");
    }
}

class Program
{
    static void Main()
    {
        IPlatform facebook = new Facebook();
        Live live1 = new Live(facebook);
        live1.Broadcast();

        IPlatform youtube = new YouTube();
        AdvancedLive live2 = new AdvancedLive(youtube);
        live2.BroadcastWithRecord();
        live2.EnableSubtitles();

        IPlatform twitch = new Twitch();
        Live live3 = new Live(twitch);
        live3.Broadcast();
    }
}
