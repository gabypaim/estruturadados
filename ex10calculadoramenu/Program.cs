using System;

class Program
{
    static void Main()
    {
        Console.Write("Dígite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Dígite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Dígite uma operação (+,-,/,*): ");
        char op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
            Console.WriteLine(num1 + num2);
            break;

            case '-':
            Console.WriteLine(num1 - num2);
            break;

            case '/':
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }
            break;
                
            case '*':
             Console.WriteLine(num1 * num2);
            break;

            default:
            Console.WriteLine("operação inválida");
            break;
        }
    }
}