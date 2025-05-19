using System;

class Program
{
    static void Main(string[] args)
    {
        FachadaBanco fachada = new FachadaBanco();

        // a) Criar usuário 1
        Usuario u1 = new Usuario(1001, "Ana");
        u1.Saldo = 500.0;
        fachada.AddUsuario(u1);
        fachada.Deposito(1001, 200.0);
        fachada.Saque(1001, 100.0);

        // b) Criar usuário 2
        Usuario u2 = new Usuario(1002, "Carlos");
        u2.Saldo = 1000.0;
        fachada.AddUsuario(u2);
        fachada.Deposito(1002, 300.0);
        fachada.Saque(1002, 1200.0); // saque maior que o saldo, deve avisar

        // c) Saque com matrícula inexistente
        fachada.Saque(9999, 100.0);
    }
}
