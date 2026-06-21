using System;
using System;
public interface IDesconto
{
    decimal Calcular(decimal valor);
}

class Program
{
    static void Main(string[] args)
    {
        decimal valorCompra = 100.00m;

        IDesconto descontoComum = new DescontoClienteComum();
        IDesconto descontoVip = new DescontoClienteVip();

        Console.WriteLine("=== Cálculo de Desconto ===");
        Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
        Console.WriteLine($"Cliente Comum (5%): R$ {descontoComum.Calcular(valorCompra):F2}");
        Console.WriteLine($"Cliente VIP (10%): R$ {descontoVip.Calcular(valorCompra):F2}");

        Console.ReadKey();
    }
}
