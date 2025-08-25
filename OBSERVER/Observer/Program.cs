using System;

class program
{
    static void Main(string[] args)
    {
        ISujeito ControladorEmail = new ControladorEmail();

        Usuario usuarioA = new Usuario("Carlos", "Normal");
        Usuario usuarioB = new Usuario("Felipe", "VIP");
        Usuario usuarioC = new Usuario("Luiz", "Normal");

        ControladorEmail.RegistrarObservador(usuarioA);
        ControladorEmail.RegistrarObservador(usuarioB);
        ControladorEmail.RegistrarObservador(usuarioC);

        Console.WriteLine("\n--- Primeira promoção ---");
        ControladorEmail.NotificarObservadores("50% de desconto em eletrônicos!");

        ControladorEmail.RemoverObservador(usuarioA);

        Console.WriteLine("\n--- Segunda promoção ---");
        ControladorEmail.NotificarObservadores("Compre 1 e leve 2 em roupas!");
    }
}