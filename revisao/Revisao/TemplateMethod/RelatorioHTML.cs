using System.Collections.Generic;
using System.Text;
using BibliotecaPatterns.Composite;

namespace BibliotecaPatterns.TemplateMethod
{
    public class RelatorioHTML : RelatorioTemplate
    {
        protected override string Formatar(IEnumerable<ItemSimples> itens)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<html><head><meta charset='utf-8'><title>Relatório Biblioteca</title></head><body>");
            sb.AppendLine("<h1>Relatório (HTML)</h1>");
            sb.AppendLine("<ul>");
            foreach (var it in itens)
            {
                sb.AppendLine($"<li>{System.Net.WebUtility.HtmlEncode(it.Titulo)} | {System.Net.WebUtility.HtmlEncode(it.Meta.ToString())} | Emprestado: {it.EstaEmprestado}</li>");
            }
            sb.AppendLine("</ul></body></html>");
            return sb.ToString();
        }
    }
}
