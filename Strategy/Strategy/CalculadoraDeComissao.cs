public class CalculadoraDeComissao
{
    private IComissaoStrategy _strategy;

    public void DefinirStrategy(IComissaoStrategy strategy)
    {
        this._strategy = strategy;
    }

    public void ExecutarCalculo(decimal valorVenda)
    {
        _strategy.Calcular(valorVenda);
    }
}