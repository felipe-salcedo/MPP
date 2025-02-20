namespace LiskovSubstitutionPrinciple
{
    public interface IInstrumentoPagamento
    {
        void Validacao();
        void ColetarPagamento();
    }
}
