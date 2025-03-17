using System;

namespace AtividadeFactory
{
    public class Motorcycle : ILandVehicle
    {
        public void StartRoute()
        {
            Console.WriteLine("Moto iniciando a rota terrestre.");
        }
    }
}
