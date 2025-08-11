using System;
using System.IO;
using BibliotecaPatterns.Composite;
using BibliotecaPatterns.Facade;
using BibliotecaPatterns.Flyweight;

namespace BibliotecaPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var metadataFactory = new MetadataFactory();
            var biblioteca = new BibliotecaFacade(metadataFactory);

            var item1 = biblioteca.CriarItem("Design Patterns - Gang of Four", "Erich Gamma", "Addison-Wesley", 1995);
            var item2 = biblioteca.CriarItem("Clean Code", "Robert C. Martin", "Pearson", 2008);
            var item3 = biblioteca.CriarItem("Design Patterns - Gang of Four (ebook)", "Erich Gamma", "Addison-Wesley", 1995);

            var colecao = new ColecaoMaterial("Série Arquitetura");
            colecao.Adicionar(item1);
            colecao.Adicionar(item3);

            biblioteca.AdicionarMaterial(colecao);
            biblioteca.AdicionarMaterial(item2);

            biblioteca.ExibirTudo();
            Console.WriteLine($"Metadados distintos criados na factory: {metadataFactory.Count}");

            Console.WriteLine("\nTentando emprestar 'Clean Code'...");
            Console.WriteLine(biblioteca.Emprestar("Clean Code") ? "Emprestado com sucesso" : "Não foi possível emprestar");

            var outDir = Directory.GetCurrentDirectory();
            biblioteca.ExportarRelatorio("txt", Path.Combine(outDir, "relatorio.txt"));
            biblioteca.ExportarRelatorio("html", Path.Combine(outDir, "relatorio.html"));
            biblioteca.ExportarRelatorio("pdf", Path.Combine(outDir, "relatorio.pdf"));

            Console.WriteLine($"\nRelatórios gerados em: {outDir}");
            Console.ReadLine();
        }
    }
}
