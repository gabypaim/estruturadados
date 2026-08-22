using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[5];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Digite um número para o índice {i}: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"indice {i}: {nums[i]}");
        }
    }
}