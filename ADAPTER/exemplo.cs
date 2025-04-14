public interface INotificacao
{
    void Enviar(string destinatario, string mensagem);
}

public class SmsLegado
{
    public void EnviarSms(string numeroTelefone, string conteudo)
    {
        Console.WriteLine($"SMS enviado para {numeroTelefone}: {conteudo}");
    }
}

public class SmsParaNotificacaoAdapter : INotificacao
{
    private readonly SmsLegado _smsLegado;

    public SmsParaNotificacaoAdapter(SmsLegado smsLegado)
    {
        _smsLegado = smsLegado;
    }

    public void Enviar(string destinatario, string mensagem)
    {
        _smsLegado.EnviarSms(numeroTelefone: destinatario, conteudo: mensagem);
    }
}


public class ClienteNotificacao
{
    public void DispararNotificacao(INotificacao notificacao)
    {
        notificacao.Enviar("+5511999999999", "Sua conta foi atualizada!");
    }
}

class Program
{
    static void Main()
    {
        var cliente = new ClienteNotificacao();

        var smsLegado = new SmsLegado();

        var adapter = new SmsParaNotificacaoAdapter(smsLegado);

        cliente.DispararNotifio(adaer);
    }
}