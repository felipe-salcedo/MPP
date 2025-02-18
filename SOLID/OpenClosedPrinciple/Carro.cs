using System;

public class Carro : Veiculo
{
    public int Assentos { get; }
    public int Portas { get; }

    public Carro(string cor, int ano, double motor, int assentos, int portas)
        : base(cor, ano, motor)
    {
        Assentos = assentos;
        Portas = portas;
    }

    public override void Criar()
    {
        Console.WriteLine($"Criando um carro {Cor}, {Ano}, {Motor} motor, {Portas} portas e {Assentos} assentos.");
        LigarMotor();
    }
}
