using System;

public class ComissaoConjunta : IComissaoStrategy
{
    public void Calcular(decimal valorVenda)
    {
        decimal comissaoTotal = valorVenda * 0.05m; // 5% de comissão total
        decimal comissaoVendedor = comissaoTotal / 2;
        decimal comissaoChefe = comissaoTotal / 2;

        Console.WriteLine("--- Cálculo de Comissão Conjunta (Produto Especial) ---");
        Console.WriteLine($"Valor da Venda: R$ {valorVenda:F2}");
        Console.WriteLine($"Comissão do Vendedor (2.5%): R$ {comissaoVendedor:F2}");
        Console.WriteLine($"Comissão do Chefe de Setor (2.5%): R$ {comissaoChefe:F2}");
        Console.WriteLine("-----------------------------------------------------\n");
    }
}