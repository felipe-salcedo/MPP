using System;
using System.Collections.Generic;

// Definição da abstração
public abstract class Poligono
{
    public abstract double CalcularArea();
}

// Classe legada que já possui a lógica para calcular a área do hexágono
public class HexagonoLegado
{
    public double ObterAreaHexagono(double lado)
    {
        return (3 * (lado * lado) * Math.Sqrt(3)) / 2;
    }
}

// Adapter que permite usar a classe legada como um Polígono
public class HexagonoAdapter : Poligono
{
    private readonly HexagonoLegado _hexagonoLegado;
    public double Lado { get; set; }

    public HexagonoAdapter(HexagonoLegado hexagonoLegado, double lado)
    {
        _hexagonoLegado = hexagonoLegado;
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return _hexagonoLegado.ObterAreaHexagono(Lado);
    }
}

class Program
{
    static void Main()
    {
        List<Poligono> poligonos = new List<Poligono>();

        HexagonoLegado hexLegado = new HexagonoLegado();
        Poligono hexagono = new HexagonoAdapter(hexLegado, 6);
        poligonos.Add(hexagono);

        foreach (var poligono in poligonos)
        {
            Console.WriteLine("Área do polígono: " + poligono.CalcularArea());
        }

        Console.ReadLine();
    }
}
