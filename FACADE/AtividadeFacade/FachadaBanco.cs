public class FachadaBanco
{
    private GerenciaLogin login;
    private GerenciaTransacoes transacoes;

    public FachadaBanco()
    {
        login = new GerenciaLogin();
        transacoes = new GerenciaTransacoes();
    }

    public void AddUsuario(Usuario usuario)
    {
        login.AddUsuario(usuario);
    }

    public void Deposito(long matricula, double valor)
    {
        Usuario usuario = login.BuscarUsuario(matricula);
        if (usuario != null)
            transacoes.Deposito(usuario, valor);
        else
            Console.WriteLine($"Usuário com matrícula {matricula} não encontrado.");
    }

    public void Saque(long matricula, double valor)
    {
        Usuario usuario = login.BuscarUsuario(matricula);
        if (usuario != null)
            transacoes.Saque(usuario, valor);
        else
            Console.WriteLine($"Usuário com matrícula {matricula} não encontrado.");
    }
}
