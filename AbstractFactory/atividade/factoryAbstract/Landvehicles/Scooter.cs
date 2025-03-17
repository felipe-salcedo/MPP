using System;

namespace AtividadeFactory
{
    public class Scooter : ILandVehicle
    {
        public void StartRoute()
        {
            Console.WriteLine("Scooter iniciando a rota terrestre.");
        }
    }
}
