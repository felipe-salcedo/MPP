public class SedanCar : Car
{
    protected override void BuildCarBodyWork()
    {
        Console.WriteLine("Produzindo carroceria Sedan (três volumes)...");
    }

    protected override void PaintCar()
    {
        Console.WriteLine("Pintando carro Sedan com tinta metálica...");
    }

    protected override void MountCarParts()
    {
        Console.WriteLine("Montando peças de carro Sedan...");
    }
}

