--Proxy
---------------------------------------------------------------------------------------------------------------------- -
using System;
namespace ProxyPattern
{
    // Interface para a imagem
    public interface IImage
    {
        void Display();
    }
    // Classe da imagem real
    public class RealImage : IImage
    {
        private string _filename;
        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk(_filename);
        }
        private void LoadFromDisk(string filename)
        {
            Console.WriteLine($"Loading {_filename} from disk.");
        }
        public void Display()
        {
            Console.WriteLine($"Displaying {_filename}");
        }
    }
    // Proxy com controle de acesso
    public class AccessControlProxyImage : IImage
    {
        private RealImage? _realImage; // Campo anulável
        private string _filename;
        private bool _hasAccess;
        public AccessControlProxyImage(string filename, bool hasAccess)
        {
            _filename = filename;
            _hasAccess = hasAccess;
        }
        public void Display()
        {
            if (_hasAccess)
            {
                if (_realImage == null)
                {
                    _realImage = new RealImage(_filename);
                }
                _realImage.Display();
            }
            else
            {
                Console.WriteLine($"Access denied to {_filename}");
            }
        }
    }
    // Proxy com lazy initialization
    public class LazyProxyImage : IImage
    {
        private RealImage? _realImage; // Campo anulável
        private string _filename;
        public LazyProxyImage(string filename)
        {
            _filename = filename;
        }
        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
    }
    // Proxy com logging
    public class LoggingProxyImage : IImage
    {
        private RealImage? _realImage; // Campo anulável
        private string _filename;
        public LoggingProxyImage(string filename)
        {
            _filename = filename;
        }
        public void Display()
        {
            LogAccess();
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
        private void LogAccess()
        {
            Console.WriteLine($"Accessing {_filename} on {DateTime.Now}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstração do Padrão de Projeto Proxy");
            // Exemplo 1: Proxy com Controle de Acesso
            Console.WriteLine("\nExemplo 1: Proxy com Controle de Acesso");
            IImage accessControlImage = new AccessControlProxyImage("test_10mb.jpg", true);
            accessControlImage.Display();
            IImage deniedAccessImage = new AccessControlProxyImage("test_10mb.jpg", false);
            deniedAccessImage.Display();
            // Exemplo 2: Proxy com Lazy Initialization
            Console.WriteLine("\nExemplo 2: Proxy com Lazy Initialization");
            IImage lazyImage = new LazyProxyImage("test_20mb.jpg");
            Console.WriteLine("Imagem ainda não carregada.");
            lazyImage.Display();
            lazyImage.Display();
            // Exemplo 3: Proxy com Logging
            Console.WriteLine("\nExemplo 3: Proxy com Logging");
            IImage loggedImage = new LoggingProxyImage("test_30mb.jpg");
            loggedImage.Display();
            loggedImage.Display();
        }
    }
}