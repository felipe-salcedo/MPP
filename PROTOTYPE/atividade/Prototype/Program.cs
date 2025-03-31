using System;

namespace Prototype
{
    public class Acessorio : ICloneable
    {
        public string Nome { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Soldado : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public Acessorio Acessorio { get; set; }

        public object Clone()
        {
            Soldado clone = (Soldado)this.MemberwiseClone();
            clone.Acessorio = (Acessorio)this.Acessorio.Clone();
            return clone;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}, Arma: {Arma}, Acessório: {Acessorio.Nome}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Soldado soldadoOriginal = new Soldado
            {
                Nome = "Soldado Original",
                Arma = "Fuzil",
                Acessorio = new Acessorio { Nome = "Capacete" }
            };

            Soldado clone1 = (Soldado)soldadoOriginal.Clone();
            clone1.Nome = "Clone 1";

            Soldado clone2 = (Soldado)soldadoOriginal.Clone();
            clone2.Nome = "Clone 2";

            Soldado clone3 = (Soldado)soldadoOriginal.Clone();
            clone3.Nome = "Clone 3";

            soldadoOriginal.Exibir();
            clone1.Exibir();
            clone2.Exibir();
            clone3.Exibir();
        }
    }
}
