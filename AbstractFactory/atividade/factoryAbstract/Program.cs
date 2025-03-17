using System;

namespace AtividadeFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            ITransportFactory transportFactory;
            // Defina a empresa: "Uber", "99" ou "Lime"
            string company = "Uber";
            // Defina o tipo de rota: "terrestre" ou "aerea"
            string routeType = "aerea";

            if (company.Equals("Uber", StringComparison.OrdinalIgnoreCase))
            {
                transportFactory = new UberTransport();
            }
            else if (company.Equals("99"))
            {
                transportFactory = new NineNineTransport();
            }
            else // Lime
            {
                transportFactory = new LimeTransport();
            }

            return new Application(transportFactory, routeType);
        }

        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.StartRoute();
            Console.ReadLine();
        }
    }
}
