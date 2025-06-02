using System;

namespace Decorator
{
    public class WhatsAppNotifierDecorator : NotifierDecorator
    {
        public WhatsAppNotifierDecorator(INotifier wrappee) : base(wrappee)
        {
        }

        public override string Send(string message)
        {
            string result = base.Send(message);
            
            result += "\n>>> Enviando WhatsApp: " + message;
            
            return result;
        }
    }
}