using System;
using System.Collections.Generic;

namespace BibliotecaPatterns.Composite
{
    public class ColecaoMaterial : Material
    {
        public string Titulo { get; }
        private readonly List<Material> _materiais = new();

        public ColecaoMaterial(string titulo)
        {
            Titulo = titulo;
        }

        public void Adicionar(Material m) => _materiais.Add(m);
        public void Remover(Material m) => _materiais.Remove(m);

        public void ExibirInfo(int indent = 0)
        {
            var pad = new string(' ', indent * 2);
            Console.WriteLine($"{pad}+ [Coleção] {Titulo}");
            foreach (var m in _materiais)
            {
                m.ExibirInfo(indent + 1);
            }
        }

        public IEnumerable<ItemSimples> GetAllItems()
        {
            foreach (var m in _materiais)
            {
                foreach (var i in m.GetAllItems())
                    yield return i;
            }
        }
    }
}
