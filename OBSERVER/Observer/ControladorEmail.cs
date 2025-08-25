using System;
using System.Collections.Generic;

public class ControladorEmail : ISujeito
{
    private List<IObservador> observadores = new List<IObservador>();

    public void RegistrarObservador(IObservador observador)
    {
        observadores.Add(observador);
        Console.WriteLine("Usuário registrado para receber promoções.");
    }

    public void RemoverObservador(IObservador observador)
    {
        observadores.Remove(observador);
        Console.WriteLine("Usuário removido da lista de promoções.");
    }

    public void NotificarObservadores(string mensagem)
    {
        foreach (var obs in observadores)
        {
            obs.Atualizar(mensagem);
        }
    }
}
