namespace BibliotecaPatterns.Flyweight
{
    public class Metadata
    {
        public string Autor { get; }
        public string Editora { get; }
        public int Ano { get; }

        public Metadata(string autor, string editora, int ano)
        {
            Autor = autor;
            Editora = editora;
            Ano = ano;
        }

        public override string ToString() =>
            $"{Autor} - {Editora} ({Ano})";
    }
}
