public class Chocolate : BebidaDecorator
{
    public Chocolate(IBebida bebida) : base(bebida) { }

    public override string GetDescricao()
    {
        return bebida.GetDescricao() + ", Chocolate";
    }

    public override double Custo()
    {
        return bebida.Custo() + 0.75;
    }
}
