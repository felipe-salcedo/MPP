using System;

class Program
{
    static void Main(string[] args)
    {
        CalculadoraDeComissao calculadora = new CalculadoraDeComissao();

        calculadora.DefinirStrategy(new ComissaoIndividual());
        calculadora.ExecutarCalculo(1000.00m);

        calculadora.DefinirStrategy(new ComissaoConjunta());
        calculadora.ExecutarCalculo(3000.00m);
        
        Console.WriteLine("Cálculos de comissão finalizados. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}