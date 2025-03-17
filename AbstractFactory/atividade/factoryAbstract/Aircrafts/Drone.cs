using System;

namespace AtividadeFactory
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Condições de vento ideais para o drone.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pacote carregado, pronto para entrega.");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Drone iniciando a rota de entrega aérea.");
        }
    }
}
