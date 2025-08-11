using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BibliotecaPatterns.Composite;

namespace BibliotecaPatterns.TemplateMethod
{
    public abstract class RelatorioTemplate
    {
        public void Exportar(IEnumerable<Material> materiais, string caminhoArquivo)
        {
            var listaItens = materiais.SelectMany(m => m.GetAllItems()).ToList();
            var conteudo = Formatar(listaItens);
            File.WriteAllText(caminhoArquivo, conteudo, Encoding.UTF8);
        }

        protected abstract string Formatar(IEnumerable<ItemSimples> itens);
    }
}
