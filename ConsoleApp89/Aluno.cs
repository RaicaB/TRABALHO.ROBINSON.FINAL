using System;

public class Aluno

{

    public string RA { get; set; }

    public string Nome { get; set; }

    public double NotaProva { get; set; }

    public double NotaTrabalho { get; set; }

    public double NotaFinal { get; private set; }



    public void ReceberDados()

    {

        Console.Write("Digite o RA: ");

        RA = Console.ReadLine();



        Console.Write("Digite o Nome: ");

        Nome = Console.ReadLine();



        Console.Write("Digite a Nota da Prova: ");

        NotaProva = double.Parse(Console.ReadLine());



        Console.Write("Digite a Nota do Trabalho: ");

        NotaTrabalho = double.Parse(Console.ReadLine());

    }



    public void CalcularMedia()

    {

        NotaFinal = (NotaProva + NotaTrabalho) / 2.0;

    }



    public bool CalcularNotaFinal()

    {

        if (NotaFinal >= 7.0)

        {

            Console.WriteLine($"{Nome} está aprovado diretamente com média {NotaFinal:F2}.");

            return true;

        }

        else

        {

            double notaNecessaria = 14 - NotaFinal;

            Console.WriteLine($"{Nome} precisa tirar {notaNecessaria:F2} na prova final para ser aprovado.");

            return false;

        }

    }



    public void ImprimirNotaFinal()

    {

        Console.WriteLine($"Nota Final de {Nome}: {NotaFinal:F2}");

    }

}
