
public class Program

{

    public static void Main(string[] args)

    {

        Aluno aluno = new Aluno();



        aluno.ReceberDados();

        aluno.CalcularMedia();

        aluno.ImprimirNotaFinal();

        aluno.CalcularNotaFinal();



        Console.ReadKey();

    }

}