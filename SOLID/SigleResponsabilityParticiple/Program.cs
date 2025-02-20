using System;

namespace SigleResponsabilityParticiple
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientService clientService = new ClientService();
            NotificationService notificationService = new NotificationService();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1 - Criar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Atualizar Cliente");
                Console.WriteLine("4 - Deletar Cliente");
                Console.WriteLine("5 - Notificar Cliente");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        clientService.CreateClient();
                        break;
                    case "2":
                        clientService.ReadClient();
                        break;
                    case "3":
                        clientService.UpdateClient();
                        break;
                    case "4":
                        clientService.DeleteClient();
                        break;
                    case "5":
                        notificationService.NotifyClient();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
