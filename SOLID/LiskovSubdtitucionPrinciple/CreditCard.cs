namespace LiskovSubstitutionPrinciple
{
    public class CreditCard : NubankCard
    {
        public override void Validacao()
        {
            Console.WriteLine("Validando Limite...");
            Console.WriteLine("Limite OK");
        }

        public override void AtualizarPontuacao()
        {
            // Implementação específica de atualização de pontuação para CreditCard
            Console.WriteLine("Pontuação do CreditCard atualizada!");
        }
    }
}
