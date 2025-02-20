namespace LiskovSubstitutionPrinciple
{
    public class DebitCard : NubankCard
    {
        public override void Validacao()
        {
            Console.WriteLine("Verificando Saldo...");
            Console.WriteLine("Saldo disponível");
        }

        public override void AtualizarPontuacao()
        {
            // Implementação específica de atualização de pontuação para DebitCard
            Console.WriteLine("Pontuação do DebitCard não é atualizada.");
        }
    }
}
