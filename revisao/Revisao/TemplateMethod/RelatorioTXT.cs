using System.Collections.Generic;
using System.Text;
using BibliotecaPatterns.Composite;

namespace BibliotecaPatterns.TemplateMethod
{
    public class RelatorioTXT : RelatorioTemplate
    {
        protected override string Formatar(IEnumerable<ItemSimples> itens)
        {
            var sb = new StringBuilder();
            sb.AppendLine("RELATÓRIO TXT - Biblioteca");
            sb.AppendLine("-------------------------");
            foreach (var it in itens)
            {
                sb.AppendLine($"{it.Titulo} | {it.Meta} | Emprestado: {it.EstaEmprestado}");
            }
            return sb.ToString();
        }
    }
}
