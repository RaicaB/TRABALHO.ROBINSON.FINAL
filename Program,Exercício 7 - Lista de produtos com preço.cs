using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Cliente> clientes = new List<Cliente>();
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU DE CLIENTES =====");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Buscar cliente por nome");
            Console.WriteLine("4 - Remover cliente");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome: ");
                    string nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.WriteLine("Nome não pode ser vazio!");
                        break;
                    }

                    Console.Write("Digite o telefone: ");
                    string telefone = Console.ReadLine();

                    Console.Write("Digite a cidade: ");
                    string cidade = Console.ReadLine();

                    clientes.Add(new Cliente(nome, telefone, cidade));
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                    break;

                case 2:
                    Console.WriteLine("\n--- Lista de Clientes ---");
                    if (clientes.Count == 0)
                        Console.WriteLine("Nenhum cliente cadastrado.");
                    else
                        clientes.ForEach(c => Console.WriteLine(c));
                    break;

                case 3:
                    Console.Write("Digite o nome do cliente para buscar: ");
                    string nomeBusca = Console.ReadLine();
                    Cliente clienteEncontrado = clientes.Find(c => c.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));

                    if (clienteEncontrado != null)
                        Console.WriteLine("Cliente encontrado: " + clienteEncontrado);
                    else
                        Console.WriteLine("Cliente não encontrado.");
                    break;

                case 4:
                    Console.Write("Digite o nome do cliente para remover: ");
                    string nomeRemover = Console.ReadLine();
                    Cliente clienteRemover = clientes.Find(c => c.Nome.Equals(nomeRemover, StringComparison.OrdinalIgnoreCase));

                    if (clienteRemover != null)
                    {
                        clientes.Remove(clienteRemover);
                        Console.WriteLine("Cliente removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Cliente não encontrado.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }
}
