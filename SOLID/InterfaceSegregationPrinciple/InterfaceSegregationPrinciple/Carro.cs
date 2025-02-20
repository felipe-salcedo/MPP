namespace LiskovSubstitutionPrinciple
{
    // Classe Carro implementando IVeiculo e IConfigureCarro
    public class Carro : IVeiculo, IConfigureCarro
    {
        string cor;
        int ano, assentos, portas;
        float motor;

        public Carro(string cor, int ano, float motor, int assentos, int portas)
        {
            // Configurando o carro
            ConfigureCarro(cor, ano, motor, assentos, portas);
            LigaVeiculo();
        }

        public void ConfigureCarro(string cor, int ano, float motor, int assentos, int portas)
        {
            this.cor = cor;
            this.ano = ano;
            this.motor = motor;
            this.assentos = assentos;
            this.portas = portas;

            Console.WriteLine($"Criando Carro: ano {ano}, cor {cor}, motor {motor}L, assentos {assentos}, portas {portas}");
        }

        public void LigaVeiculo()
        {
            Console.WriteLine("Ligando o Carro");
        }
    }
}
