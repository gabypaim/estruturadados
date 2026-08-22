using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Seu número é negativo");
        } else if (num > 0) {
            Console.WriteLine("Seu número é postivo");
        } else {
            Console.WriteLine("Seu número é zero");
        }
    }
}