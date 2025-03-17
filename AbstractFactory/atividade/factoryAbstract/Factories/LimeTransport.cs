using System;

namespace AtividadeFactory
{
    public class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public List<ILandVehicle> CreateTransportVehicles()
        {
            return new List<ILandVehicle>
            {
                new Scooter()
            };
        }
    }
}
