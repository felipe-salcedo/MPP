using System;

namespace TemplateMethodExemplo
{
    abstract class Bebida
    {
        public void Preparar()
        {
            FerverAgua();
            AdicionarIngrediente();
            ServirNaXicara();
            Console.WriteLine();
        }

        private void FerverAgua()
        {
            Console.WriteLine("Fervendo a água...");
        }

        protected abstract void AdicionarIngrediente();

        private void ServirNaXicara()
        {
            Console.WriteLine("Servindo na xícara.");
        }
    }
}