using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um número entre 0 e 10: ");
        int num = int.Parse(Console.ReadLine());

        while ((num < 0) || (num > 10))
        {
            Console.WriteLine("Número inválido");
            Console.Write("Digite um número entre 0 e 10: ");
            num = int.Parse(Console.ReadLine());
        }

        Console.Write($"Seu número é {num}");
    }

}