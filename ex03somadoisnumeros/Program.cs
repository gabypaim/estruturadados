using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o PRIMEIRO número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o SEGUNDO número: ");
        int num2 = int.Parse(Console.ReadLine());

        int soma = num1 + num2;
        Console.WriteLine($"A soma dos dois números é {soma}");
    }
}