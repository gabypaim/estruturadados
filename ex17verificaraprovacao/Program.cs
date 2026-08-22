using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua média: ");
        double media = double.Parse(Console.ReadLine());
        Console.WriteLine(EstaAprovado(media));
    }

    static bool EstaAprovado(double media)
    {
        return media >= 7;
    }
}