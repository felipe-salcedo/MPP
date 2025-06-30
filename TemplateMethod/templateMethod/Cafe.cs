using System;

namespace TemplateMethodExemplo
{
    class Cafe : Bebida
    {
        protected override void AdicionarIngrediente()
        {
            Console.WriteLine("Adicionando o pó de café.");
        }
    }
}