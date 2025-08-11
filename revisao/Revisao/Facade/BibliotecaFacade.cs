using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BibliotecaPatterns.Composite;
using BibliotecaPatterns.Flyweight;
using BibliotecaPatterns.TemplateMethod;

namespace BibliotecaPatterns.Facade
{
    public class BibliotecaFacade
    {
        private readonly List<Material> _materiais = new();
        private readonly MetadataFactory _metadataFactory;

        public BibliotecaFacade(MetadataFactory metadataFactory)
        {
            _metadataFactory = metadataFactory;
        }

        public void AdicionarMaterial(Material m) => _materiais.Add(m);

        public ItemSimples BuscarItemPorTitulo(string titulo)
        {
            return _materiais
                .SelectMany(m => m.GetAllItems())
                .FirstOrDefault(i => string.Equals(i.Titulo, titulo, StringComparison.OrdinalIgnoreCase));
        }

        public bool Emprestar(string titulo)
        {
            var item = BuscarItemPorTitulo(titulo);
            if (item == null || item.EstaEmprestado) return false;
            item.Emprestar();
            return true;
        }

        public bool Devolver(string titulo)
        {
            var item = BuscarItemPorTitulo(titulo);
            if (item == null || !item.EstaEmprestado) return false;
            item.Devolver();
            return true;
        }

        public void ExportarRelatorio(string tipo, string caminhoArquivo)
        {
            RelatorioTemplate rel = tipo?.ToLowerInvariant() switch
            {
                "pdf" => new RelatorioPDF(),
                "html" => new RelatorioHTML(),
                _ => new RelatorioTXT()
            };
            rel.Exportar(_materiais, caminhoArquivo);
        }

        public ItemSimples CriarItem(string titulo, string autor, string editora, int ano)
        {
            var meta = _metadataFactory.GetMetadata(autor, editora, ano);
            return new ItemSimples(titulo, meta);
        }

        public void ExibirTudo()
        {
            Console.WriteLine("=== Conteúdo da Biblioteca ===");
            foreach (var m in _materiais)
            {
                m.ExibirInfo();
            }
        }
    }
}
