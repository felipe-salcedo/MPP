using System;

public class ComissaoIndividual : IComissaoStrategy
{
    public void Calcular(decimal valorVenda)
    {
        decimal comissao = valorVenda * 0.05m; // 5% de comissão
        Console.WriteLine("--- Cálculo de Comissão Individual ---");
        Console.WriteLine($"Valor da Venda: R$ {valorVenda:F2}");
        Console.WriteLine($"Comissão do Vendedor (5%): R$ {comissao:F2}");
        Console.WriteLine("--------------------------------------\n");
    }
}