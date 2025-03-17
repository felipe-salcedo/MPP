using System;

namespace AtividadeFactory
{
    public class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos a 25km, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo, vôo autorizado.");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
    