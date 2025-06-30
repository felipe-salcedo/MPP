public abstract class Car
{
    // Template Method
    public void BuildCar()
    {
        BuildCarBodyWork();
        PaintCar();
        MountCarParts();
        Console.WriteLine("Carro finalizado!\n");
    }

    protected abstract void BuildCarBodyWork();
    protected abstract void PaintCar();
    protected abstract void MountCarParts();
}
