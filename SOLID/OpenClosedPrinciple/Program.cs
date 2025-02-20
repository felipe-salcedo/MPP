using System;

class Program
{
    static void Main(string[] args)
    {
        Veiculo carro = new Carro("Vermelho", 2021, 2.0, 5, 4);
        carro.Criar();

        Console.WriteLine();

        Veiculo moto = new Moto("Azul", 2022, 150);
        moto.Criar();

        Console.ReadKey();
    }
}
