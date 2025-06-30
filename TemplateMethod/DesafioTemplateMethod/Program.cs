class Program
{
    static void Main(string[] args)
    {
        Car sedan = new SedanCar();
        Console.WriteLine("Construindo carro Sedan:");
        sedan.BuildCar();

        Car hatch = new HatchCar();
        Console.WriteLine("Construindo carro Hatch:");
        hatch.BuildCar();
    }
}
