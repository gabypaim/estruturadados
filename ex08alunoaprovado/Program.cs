using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite sua segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2) / 2;

        if (media >= 7)
        {
            Console.WriteLine("Aprovado!");

        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("Recuperação");
        } else
        {
            Console.WriteLine("Reprovado");
        }

    }
}