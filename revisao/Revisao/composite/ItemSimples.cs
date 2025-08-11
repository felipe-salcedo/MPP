using System;
using System.Collections.Generic;
using BibliotecaPatterns.Flyweight;

namespace BibliotecaPatterns.Composite
{
    public class ItemSimples : Material
    {
        public string Titulo { get; }
        public Metadata Meta { get; }
        public bool EstaEmprestado { get; private set; } = false;

        public ItemSimples(string titulo, Metadata meta)
        {
            Titulo = titulo;
            Meta = meta;
        }

        public void Emprestar()
        {
            if (EstaEmprestado) throw new InvalidOperationException("Item já está emprestado.");
            EstaEmprestado = true;
        }

        public void Devolver()
        {
            if (!EstaEmprestado) throw new InvalidOperationException("Item não está emprestado.");
            EstaEmprestado = false;
        }

        public void ExibirInfo(int indent = 0)
        {
            var pad = new string(' ', indent * 2);
            Console.WriteLine($"{pad}- [Item] {Titulo} | {Meta} | Emprestado: {EstaEmprestado}");
        }

        public IEnumerable<ItemSimples> GetAllItems()
        {
            yield return this;
        }
    }
}

