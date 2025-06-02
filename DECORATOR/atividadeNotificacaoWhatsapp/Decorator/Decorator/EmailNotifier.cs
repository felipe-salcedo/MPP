using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EmailNotifier : INotifier
    {
        public string Send(string message)
        {
            return $"Email enviado: {message}";
        }
    }
}
