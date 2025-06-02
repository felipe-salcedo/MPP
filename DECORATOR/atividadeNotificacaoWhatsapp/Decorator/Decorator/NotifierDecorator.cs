using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class NotifierDecorator : INotifier
    {
        protected INotifier _wrappedNotifier; // Renomeado para maior clareza (era _notifier)

        public NotifierDecorator(INotifier notifier)
        {
            _wrappedNotifier = notifier;
        }

        // O decorator delega o trabalho para o objeto embrulhado.
        // As subclasses concretas podem adicionar algo antes ou depois.
        public virtual string Send(string message)
        {
            // Se _wrappedNotifier for nulo, pode indicar um erro de configuração
            // ou que este é o decorator mais interno de uma cadeia que não
            // termina em um ConcreteComponent (o que seria um uso atípico).
            // No nosso exemplo, ele sempre terá uma referência válida.
            if (_wrappedNotifier != null)
            {
                return _wrappedNotifier.Send(message);
            }
            return string.Empty; // Ou lançar uma exceção, dependendo da lógica de negócios
        }
    }
}

