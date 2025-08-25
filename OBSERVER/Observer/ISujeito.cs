public interface ISujeito
{
    void RegistrarObservador(IObservador observador);
    void RemoverObservador(IObservador observador);
    void NotificarObservadores(string mensagem);
}