using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias de Carro e Moto
            Carro carro = new Carro("Vermelho", 2023, 2.0f, 5, 4);
            Moto moto = new Moto("Preta", 2022, 1.0f);
        }
    }
}
