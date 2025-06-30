public class HatchCar : Car
{
    protected override void BuildCarBodyWork()
    {
        Console.WriteLine("Produzindo carroceria Hatch (dois volumes)...");
    }

    protected override void PaintCar()
    {
        Console.WriteLine("Pintando carro Hatch com tinta sólida...");
    }

    protected override void MountCarParts()
    {
        Console.WriteLine("Montando peças de carro Hatch...");
    }
}
