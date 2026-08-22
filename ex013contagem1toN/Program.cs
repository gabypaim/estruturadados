using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o ultimo número da contagem: ");
        int N = int.Parse(Console.ReadLine());
  
        int soma = 0;

        for (int c = 1; c <= N; c++)
        {
            soma += c;
        }
        Console.WriteLine(soma);
    }
}