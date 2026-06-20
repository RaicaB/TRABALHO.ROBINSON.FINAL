using System;
using System.Collections.Generic;
using System.Text;
public class FuncionarioComissionado : Funcionario
{
    public double TotalVendas { get; set; }
    public double PercentualComissao { get; set; }

    public void ReceberDadosComissionado()
    {
        base.ReceberDados();
        Console.Write("Digite o total de vendas: ");
        TotalVendas = double.Parse(Console.ReadLine());

        Console.Write("Digite o percentual de comissão (%): ");
        PercentualComissao = double.Parse(Console.ReadLine());
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + (TotalVendas * PercentualComissao / 100);
    }

    public override void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo} (Comissionado)");
        Console.WriteLine($"Salário Base: {SalarioBase}");
        Console.WriteLine($"Total de Vendas: {TotalVendas}");
        Console.WriteLine($"Percentual de Comissão: {PercentualComissao}%");
        Console.WriteLine($"Salário Final: {CalcularSalarioFinal()}");
    }
}
