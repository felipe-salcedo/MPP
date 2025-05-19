public class GerenciaTransacoes
{
    public void Deposito(Usuario usuario, double valor)
    {
        usuario.Saldo += valor;
    }

    public void Saque(Usuario usuario, double valor)
    {
        if (usuario.Saldo >= valor)
            usuario.Saldo -= valor;
        else
            Console.WriteLine($"Usuário {usuario.Nome} não possui saldo suficiente.");
    }
}
