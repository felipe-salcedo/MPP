using System;

namespace AtividadeFactory
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando ventos para o helicóptero...");
        }

        public void GetCargo()
        {
            Console.WriteLine("Carga e passageiros a bordo, pronto para decolar.");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Helicóptero iniciando a rota aérea.");
        }
    }
}
