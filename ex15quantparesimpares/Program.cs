using System;

class Program
{
    static void Main()
    {
        int contpar = 0;
        int contimp = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número para verificarmos se é par ou ímpar: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                contpar++;
            }else
            {
                contimp++;
            }
        }

        Console.WriteLine($"Há {contpar} números pares e {contimp} números ímpares");
    }
}