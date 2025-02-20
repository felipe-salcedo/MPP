using System;

public class Moto : Veiculo
{
    public Moto(string cor, int ano, double motor)
        : base(cor, ano, motor)
    {
    }

    public override void Criar()
    {
        Console.WriteLine($"Criando uma moto {Cor}, {Ano}, {Motor} cilindradas.");
        LigarMotor();
    }
}
