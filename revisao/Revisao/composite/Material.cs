using System.Collections.Generic;

namespace BibliotecaPatterns.Composite
{
    public interface Material
    {
        string Titulo { get; }
        void ExibirInfo(int indent = 0);
        IEnumerable<ItemSimples> GetAllItems();
    }
}

