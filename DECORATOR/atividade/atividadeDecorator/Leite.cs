public class Leite : BebidaDecorator
{
    public Leite(IBebida bebida) : base(bebida) { }

    public override string GetDescricao()
    {
        return bebida.GetDescricao() + ", Leite";
    }

    public override double Custo()
    {
        return bebida.Custo() + 0.50;
    }
}
