using System;

namespace AtividadeFactory
{
    public class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public List<ILandVehicle> CreateTransportVehicles()
        {
            return new List<ILandVehicle>
            {
                new Motorcycle()
            };
        }
    }
}
