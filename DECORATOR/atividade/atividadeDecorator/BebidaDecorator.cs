public abstract class BebidaDecorator : IBebida
{
    protected IBebida bebida;

    public BebidaDecorator(IBebida bebida)
    {
        this.bebida = bebida;
    }

    public virtual string GetDescricao()
    {
        return bebida.GetDescricao();
    }

    public virtual double Custo()
    {
        return bebida.Custo();
    }
}
