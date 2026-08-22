using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número número: ");
        double num2 = double.Parse(Console.ReadLine());

        double soma = num1 + num2;
        double subtrair = num1 - num2;
        double vezes = num1 * num2;
        double dividir = num1 / num2;


        Console.WriteLine($"Seu número somado com o segundo é {soma}, subtraido é igual {subtrair}, multiplicado é igual {vezes} e dividido é {dividir}. ");
    }
}