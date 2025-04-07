using System;
using System.Collections.Generic;

namespace ProxyPattern
{
    public interface IFileDownloader
    {
        void DownloadFile(string url);
    }

    public class FileDownloadService : IFileDownloader
    {
        public void DownloadFile(string url)
        {
            // Simula o download do arquivo
            Console.WriteLine($"Baixando arquivo de {url}...");
        }
    }

    // Proxy que gerencia a confirmação do usuário e o cache dos downloads
    public class FileDownloaderProxy : IFileDownloader
    {
        private FileDownloadService? _realService;
        private Dictionary<string, bool> _cache = new Dictionary<string, bool>();

        public void DownloadFile(string url)
        {
            // Verifica se o arquivo já foi baixado (cache)
            if (_cache.ContainsKey(url))
            {
                Console.WriteLine("Arquivo já foi baixado anteriormente. Utilizando cache.");
                return;
            }

            // Solicita confirmação do usuário antes de iniciar o download
            Console.Write($"Deseja baixar o arquivo de {url}? (s/n): ");
            string? resposta = Console.ReadLine();

            if (resposta != null && resposta.ToLower() == "s")
            {
                // Inicializa o serviço real somente quando necessário (lazy initialization)
                if (_realService == null)
                {
                    _realService = new FileDownloadService();
                }
                _realService.DownloadFile(url);
                // Após o download, registra a URL no cache
                _cache[url] = true;
            }
            else
            {
                Console.WriteLine("Download cancelado pelo usuário.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstração do Padrão Proxy para Download de Arquivos");

            // Instancia o proxy
            IFileDownloader downloader = new FileDownloaderProxy();

            // Primeiro download: solicita confirmação e efetua o download
            Console.WriteLine("\nTentativa de download 1:");
            downloader.DownloadFile("http://exemplo.com/arquivo1.zip");

            // Segunda tentativa para o mesmo arquivo: usa o cache e não realiza download
            Console.WriteLine("\nTentativa de download 2 (mesmo arquivo):");
            downloader.DownloadFile("http://exemplo.com/arquivo1.zip");

            // Tentativa de download para outro arquivo
            Console.WriteLine("\nTentativa de download 3 (arquivo diferente):");
            downloader.DownloadFile("http://exemplo.com/arquivo2.zip");
        }
    }
}
