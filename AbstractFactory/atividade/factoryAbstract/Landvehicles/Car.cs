using System;

namespace AtividadeFactory
{
    public class Car : ILandVehicle
    {
        public void StartRoute()
        {
            Console.WriteLine("Carro iniciando a rota terrestre.");
        }
    }
}
