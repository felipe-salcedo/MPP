namespace LiskovSubstitutionPrinciple
{
    public abstract class NubankCard : IInstrumentoPagamento, INubankRewards
    {
        public void ColetarPagamento()
        {
            Console.WriteLine("Pagamento realizado");
        }

        public virtual void Validacao()
        {
            // Validação cartão
        }

        public virtual void AtualizarPontuacao()
        {
            Console.WriteLine("Atualizando pontuação do cliente...");
        }
    }
}
