using System;

namespace AtividadeFactory
{
    public class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public List<ILandVehicle> CreateTransportVehicles()
        {
            return new List<ILandVehicle>
            {
                new Car(),
                new Motorcycle()
            };
        }
    }
}
