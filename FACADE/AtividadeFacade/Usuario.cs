public class Usuario
{
    public string Nome { get; set; }
    public long Matricula { get; set; }
    public double Saldo { get; set; }

    public Usuario() { }

    public Usuario(long matricula, string nome)
    {
        Matricula = matricula;
        Nome = nome;
        Saldo = 0.0;
    }
}
