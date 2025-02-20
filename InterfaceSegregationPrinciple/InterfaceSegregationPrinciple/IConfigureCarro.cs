namespace LiskovSubstitutionPrinciple
{
    // Interface específica para configurações de Carro
    public interface IConfigureCarro
    {
        void ConfigureCarro(string cor, int ano, float motor, int assentos, int portas);
    }
}
