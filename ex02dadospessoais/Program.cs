using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá! Qual seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Olá! Qual sua idade?");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Olá! Qual sua cidade?");
        string cidade = Console.ReadLine();

        Console.WriteLine($"Então você se chama {nome} tem {idade} e mora {cidade}");
    }
}