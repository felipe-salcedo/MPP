using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SMSNotifierDecorator : NotifierDecorator
    {
        public SMSNotifierDecorator(INotifier notifier) : base(notifier) { }

        public override string Send(string message)
        {
            string baseNotification = base.Send(message); // Chama o Send() do objeto embrulhado
            string smsNotification = $"SMS enviado: {message}";

            // Concatena a notificação base com a nova funcionalidade
            // Verifica se baseNotification não é vazia para evitar linhas em branco desnecessárias
            // se o Send() do wrappedNotifier retornasse string.Empty por algum motivo.
            if (!string.IsNullOrEmpty(baseNotification))
            {
                return $"{baseNotification}\n{smsNotification}";
            }
            return smsNotification;
        }
    }
}
