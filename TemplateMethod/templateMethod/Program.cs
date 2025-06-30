using System;

namespace TemplateMethodExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preparando Chá:");
            Bebida cha = new Cha();
            cha.Preparar();
            Console.WriteLine("Preparando Café:");
            Bebida cafe = new Cafe();
            cafe.Preparar();
        }
    }
}
