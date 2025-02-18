using System;

public abstract class Veiculo
{
    public string Cor { get; }
    public int Ano { get; }
    public double Motor { get; }

    public Veiculo(string cor, int ano, double motor)
    {
        Cor = cor;
        Ano = ano;
        Motor = motor;
    }

    public abstract void Criar();

    public virtual void LigarMotor()
    {
        Console.WriteLine("Ligando os motores");
    }
}
