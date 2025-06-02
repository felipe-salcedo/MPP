using System;

class Program
{
    static void Main(string[] args)
    {
        IBebida bebida = new Cafe();
        Console.WriteLine($"{bebida.GetDescricao()} - R$ {bebida.Custo():0.00}");

        bebida = new Leite(bebida);
        Console.WriteLine("Adicionando Leite");
        Console.WriteLine($"{bebida.GetDescricao()} - R$ {bebida.Custo():0.00}");

        bebida = new Acucar(bebida);
        Console.WriteLine("Adicionando Açúcar");
        Console.WriteLine($"{bebida.GetDescricao()} - R$ {bebida.Custo():0.00}");

        bebida = new Chocolate(bebida);
        Console.WriteLine("Adicionando Chocolate");
        Console.WriteLine($"{bebida.GetDescricao()} - R$ {bebida.Custo():0.00}");

        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
