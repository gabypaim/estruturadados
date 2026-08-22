using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite um número para a tabuada: ");
        double num = double.Parse(Console.ReadLine());

        for (int c = 1; c <= 10; c++)
        {
            double resultado = num * c;
            Console.WriteLine($"{num} x {c} = {resultado}");
        }
    }
}