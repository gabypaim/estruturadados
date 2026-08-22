using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] medias = new double[5];
        double somaMedias = 0;

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write($"Digite o nome do {i + 1}° aluno: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Digite a primeira nota de {nomes[i]}: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write($"Digite a segunda nota de {nomes[i]}: ");
            double nota2 = double.Parse(Console.ReadLine());

            medias[i] = CalcularMedia(nota1, nota2);
            somaMedias += medias[i];
        }

        Console.WriteLine("\nBOLETIM");

        for (int i = 0; i < nomes.Length; i++)
        {
            string situacao = ObterSituacao(medias[i]);

            Console.WriteLine($"Nome: {nomes[i]}");
            Console.WriteLine($"Média: {medias[i]}");
            Console.WriteLine($"Situação: {situacao}");
        }

        double mediaGeral = somaMedias / medias.Length;
        Console.WriteLine($"\nMédia geral da turma: {mediaGeral}");
    }

    static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1+nota2) / 2;
    }

    static string ObterSituacao(double media)
    {
        if (media >= 7)
        {
            return "Está aprovada(o)";
        }
        else if (media >= 5)
        {
            return "Está de Recuperação";
        }
        else
        {
            return "Está reprovada(o)";
        }
    }
}