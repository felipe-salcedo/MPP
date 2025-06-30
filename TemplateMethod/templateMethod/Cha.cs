using System;

namespace TemplateMethodExemplo
{
    class Cha : Bebida
    {
        protected override void AdicionarIngrediente()
        {
            Console.WriteLine("Adicionando o saquinho de chá.");
        }
    }
}
