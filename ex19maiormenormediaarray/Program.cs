using System;

class Program
{
    static void Main()
    {
        double[] nums = new double[8];
        double soma = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("Digite um número para verificarmos: ");
            nums[i] = double.Parse(Console.ReadLine());
            soma += nums[i];
        }

        double maiornum = nums[0];
        double menornum = nums[0];
        double media = soma / nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maiornum)
            {
                maiornum = nums[i];
            };
            if (nums[i] < menornum)
            {
                menornum = nums[i];
            }
        }
        
        Console.WriteLine($"Maior número: {maiornum}");
        Console.WriteLine($"Menor número: {menornum}");
        Console.WriteLine($"Média: {media}");
    }
}