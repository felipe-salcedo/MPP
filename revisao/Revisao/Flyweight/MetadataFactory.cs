using System.Collections.Generic;

namespace BibliotecaPatterns.Flyweight
{
    public class MetadataFactory
    {
        private readonly Dictionary<string, Metadata> _metadados = new();

        private string Key(string autor, string editora, int ano)
            => $"{autor}|{editora}|{ano}";

        public Metadata GetMetadata(string autor, string editora, int ano)
        {
            var key = Key(autor, editora, ano);
            if (!_metadados.TryGetValue(key, out var meta))
            {
                meta = new Metadata(autor, editora, ano);
                _metadados[key] = meta;
            }
            return meta;
        }

        public int Count => _metadados.Count;
    }
}
