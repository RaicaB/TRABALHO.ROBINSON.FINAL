using System;
using System.Collections.Generic;
using System.Text;
using System;
public class FuncionarioCLT : Funcionario
{
    public double Bonus { get; set; }

    public void ReceberDadosCLT()
    {
        base.ReceberDados();
        Console.Write("Digite o bônus: ");
        Bonus = double.Parse(Console.ReadLine());
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + Bonus;
    }

    public override void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo} (CLT)");
        Console.WriteLine($"Salário Base: {SalarioBase}");
        Console.WriteLine($"Bônus: {Bonus}");
        Console.WriteLine($"Salário Final: {CalcularSalarioFinal()}");
    }
}
