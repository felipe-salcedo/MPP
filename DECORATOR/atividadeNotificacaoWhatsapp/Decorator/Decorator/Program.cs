using Decorator;
using System;

namespace DecoratorPatternExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Notificação simples por e-mail
            INotifier emailNotifier = new EmailNotifier();
            Console.WriteLine("--- Notificação Simples por Email ---");
            Console.WriteLine(emailNotifier.Send("Olá, Mundo!"));
            Console.WriteLine();

            // Notificação por E-mail + SMS
            INotifier emailNotifierBaseForSms = new EmailNotifier();
            INotifier emailAndSmsNotifier = new SMSNotifierDecorator(emailNotifierBaseForSms);
            Console.WriteLine("--- Notificação por Email + SMS ---");
            Console.WriteLine(emailAndSmsNotifier.Send("Alerta Importante!"));
            Console.WriteLine();

            // Notificação por E-mail + SMS + Slack
            INotifier emailNotifierBaseForFull = new EmailNotifier();
            INotifier smsAndEmailNotifier = new SMSNotifierDecorator(emailNotifierBaseForFull);
            INotifier fullNotifier = new SlackNotifierDecorator(smsAndEmailNotifier);
            Console.WriteLine("--- Notificação por Email + SMS + Slack ---");
            Console.WriteLine(fullNotifier.Send("Lançamento da Nova Funcionalidade!"));
            Console.WriteLine();

            // Notificação por E-mail + WhatsApp
            INotifier emailNotifierBaseForWhatsApp = new EmailNotifier();
            INotifier emailAndWhatsAppNotifier = new WhatsAppNotifierDecorator(emailNotifierBaseForWhatsApp);
            Console.WriteLine("--- Notificação por Email + WhatsApp ---");
            Console.WriteLine(emailAndWhatsAppNotifier.Send("Confirmação de cadastro!"));
            Console.WriteLine();

            // Notificação completa: E-mail + SMS + Slack + WhatsApp
            INotifier completeNotifier = new WhatsAppNotifierDecorator(
                                           new SlackNotifierDecorator(
                                               new SMSNotifierDecorator(
                                                   new EmailNotifier()
                                               )
                                           ));
            Console.WriteLine("--- Notificação Completa (Email + SMS + Slack + WhatsApp) ---");
            Console.WriteLine(completeNotifier.Send("Urgente: Reunião cancelada!"));
            Console.WriteLine();

            // Alternativa: E-mail + WhatsApp + Slack (sem SMS)
            INotifier alternativeNotifier = new SlackNotifierDecorator(
                                              new WhatsAppNotifierDecorator(
                                                  new EmailNotifier()
                                              ));
            Console.WriteLine("--- Notificação por Email + WhatsApp + Slack ---");
            Console.WriteLine(alternativeNotifier.Send("Lembrete: Pagamento pendente"));
            Console.WriteLine();
        }
    }
}