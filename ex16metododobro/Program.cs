using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(CalcularDobro(num));
    }
    static int CalcularDobro(int num)
    {
        return num * 2;
    }
}