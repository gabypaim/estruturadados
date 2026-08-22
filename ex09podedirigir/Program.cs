using System;

class Program
{
    static void Main()
    {
        Console.Write("Qual sua idade? ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Você possui CNH? (S/N) ");
        char cnh = char.Parse(Console.ReadLine().ToUpper());
        
        if (idade >= 18 && cnh == 'S')
        {
            Console.WriteLine("Você pode dirigir legalmente!");
        } else if (idade >= 18 && cnh == 'N')
        {
            Console.WriteLine("Você não possui CNH");
        } else
        {
            Console.WriteLine("Você não possui idade suficiente");
        }
    }
}               
