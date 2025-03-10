interface IVehicle
{
    void StartRoute();

    void GetCargo();
}

class Car : IVehicle
{
    public void StartRoute()
    {
        Console.WriteLine("Carro pronto para trasportar passageiros");
    }

    public void GetCargo()
    {
        Console.WriteLine("Carro pronto para pegar os passageiros");
    }
}

class Motorcycle : IVehicle
{
    public void StartRoute()
    {
        Console.WriteLine("Moto pronto para trasportar produtos");
    }

    public void GetCargo()
    {
        Console.WriteLine("Moto pronto para pegar os produtos");
    }
}

class Bike : IVehicle
{
    public void StartRoute()
    {
        Console.WriteLine("Bicicleta pronta para trasportar o ciclista");
    }

    public void GetCargo()
    {
        Console.WriteLine("Bicicleta pronta para ser conduida pelo ciclista");
    }
}

abstract class Transport
{
    public void StartTransport()
    {
        IVehicle vehicle = CreateTransport();
        vehicle.StartRoute();
    }

    protected abstract IVehicle CreateTransport();
}

class CarTransport : Transport
{
    protected override IVehicle CreateTransport()
    {
        return new Car();
    }
}

class MotorcycleTransport : Transport
{
    protected override IVehicle CreateTransport()
    {
        return new Motorcycle();
    }
}

class BikeTransport : Transport
{
    protected override IVehicle CreateTransport()
    {
        return new Bike();
    }
}