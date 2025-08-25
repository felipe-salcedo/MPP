using System;

public class Usuario : IObservador
{
    public string Nome { get; private set; }
    public string Tipo { get; private set; }

    public Usuario(string nome, string tipo)
    {
        Nome = nome;
        Tipo = tipo;
    }

    public void Atualizar(string mensagem)
    {
        if (Tipo == "VIP")
        {
            Console.WriteLine($"[VIP] Olá {Nome}, promoção exclusiva: {mensagem}");
        }
        else
        {
            Console.WriteLine($"Olá {Nome}, temos uma nova promoção: {mensagem}");
        }
    }
}