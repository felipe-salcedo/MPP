namespace Decorator;

// Concrete Decorator B
public class SlackNotifierDecorator : NotifierDecorator
{
    public SlackNotifierDecorator(INotifier notifier) : base(notifier) { }

    public override string Send(string message)
    {
        string baseNotification = base.Send(message); // Chama o Send() do objeto embrulhado
        string slackNotification = $"Slack enviado: {message}";

        if (!string.IsNullOrEmpty(baseNotification))
        {
            return $"{baseNotification}\n{slackNotification}";
        }
        return slackNotification;
    }
}