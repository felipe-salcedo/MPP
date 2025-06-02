public class Acucar : BebidaDecorator
{
    public Acucar(IBebida bebida) : base(bebida) { }

    public override string GetDescricao()
    {
        return bebida.GetDescricao() + ", Açúcar";
    }

    public override double Custo()
    {
        return bebida.Custo() + 0.20;
    }
}
