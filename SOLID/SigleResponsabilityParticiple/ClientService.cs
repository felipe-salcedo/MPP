using System;
using System.Collections.Generic;
using System.Linq;

namespace SigleResponsabilityParticiple
{
    public class ClientService
    {
        private List<Client> _clients = new List<Client>();
        private int _nextId = 1;

        public void CreateClient()
        {
            Console.Write("Digite o nome do cliente: ");
            string name = Console.ReadLine();

            Client client = new Client
            {
                Id = _nextId++,
                Name = name
            };

            _clients.Add(client);
            Console.WriteLine("Cliente criado com sucesso!");
        }

        public void ReadClient()
        {
            if (_clients.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }

            Console.WriteLine("\nLista de Clientes:");
            foreach (var client in _clients)
            {
                Console.WriteLine($"ID: {client.Id} - Nome: {client.Name}");
            }
        }

        public void UpdateClient()
        {
            Console.Write("Digite o ID do cliente a ser atualizado: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var client = _clients.FirstOrDefault(c => c.Id == id);
                if (client != null)
                {
                    Console.Write("Digite o novo nome do cliente: ");
                    string newName = Console.ReadLine();
                    client.Name = newName;
                    Console.WriteLine("Cliente atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }

        public void DeleteClient()
        {
            Console.Write("Digite o ID do cliente a ser deletado: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var client = _clients.FirstOrDefault(c => c.Id == id);
                if (client != null)
                {
                    _clients.Remove(client);
                    Console.WriteLine("Cliente deletado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }
    }
}
