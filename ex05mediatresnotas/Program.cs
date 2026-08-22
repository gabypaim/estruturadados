using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite sua segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite sua terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        Console.Write($"Sua média é {media}");
    }
}