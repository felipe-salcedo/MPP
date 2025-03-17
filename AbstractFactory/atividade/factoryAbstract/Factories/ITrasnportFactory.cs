using System;

namespace AtividadeFactory
{
    public interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        List<ILandVehicle> CreateTransportVehicles();
    }
}
