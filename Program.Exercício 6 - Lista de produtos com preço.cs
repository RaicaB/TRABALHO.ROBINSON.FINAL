using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();
        double valorTotal = 0;

        Console.WriteLine("=== Cadastro de Produtos ===");

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"\nProduto {i}:");

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine());

            produtos.Add(new Produto(nome, preco));
            valorTotal += preco;
        }

        Console.WriteLine("\n--- Produtos cadastrados ---");
        foreach (Produto p in produtos)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine($"\nValor total: R$ {valorTotal:F2}");
        Console.ReadKey();
    }
}
