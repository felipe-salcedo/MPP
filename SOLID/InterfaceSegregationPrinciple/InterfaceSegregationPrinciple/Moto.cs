namespace LiskovSubstitutionPrinciple
{
    // Classe Moto implementando IVeiculo e IConfigureMoto
    public class Moto : IVeiculo, IConfigureMoto
    {
        string cor;
        int ano;
        float motor;

        public Moto(string cor, int ano, float motor)
        {
            // Configurando a moto
            ConfigureMoto(cor, ano, motor);
            LigaVeiculo();
        }

        public void ConfigureMoto(string cor, int ano, float motor)
        {
            this.cor = cor;
            this.ano = ano;
            this.motor = motor;

            Console.WriteLine($"Criando Moto: ano {ano}, cor {cor}, motor {motor} cilindradas");
        }

        public void LigaVeiculo()
        {
            Console.WriteLine("Ligando a Moto");
        }
    }
}
