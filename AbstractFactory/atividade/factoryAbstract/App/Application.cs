using System;

namespace AtividadeFactory
{
    public class Application
    {
        private IAircraft aircraft;
        private List<ILandVehicle> vehicles;
        private string routeType;

        public Application(ITransportFactory factory, string routeType)
        {
            this.routeType = routeType;
            if (routeType.Equals("terrestre", StringComparison.OrdinalIgnoreCase))
            {
                vehicles = factory.CreateTransportVehicles();
            }
            else
            {
                aircraft = factory.CreateTransportAircraft();
            }
        }

        public void StartRoute()
        {
            if (routeType.Equals("terrestre", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var vehicle in vehicles)
                {
                    vehicle.StartRoute();
                }
            }
            else
            {
                aircraft.StartRoute();
            }
        }
    }
}
