namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();
        
        lista.InserirNoInicio(20);
        lista.InserirNoFinal(10);
        lista.InserirNoInicio(2);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(50);
        
        Console.WriteLine($"Lista antes\n");
        lista.Mostrar();
        
        lista.Remover(10);
        lista.RemoverDoInicio();
        lista.InserirDepoisDe(20,25);
        
        No? encontrado;

        encontrado = lista.Buscar(10);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(20);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(40);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(50);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");
        
        Console.Write("Lista agora:\n");
        lista.Mostrar();
        Console.WriteLine($"Quantidade: {lista.Contar()}");
        Console.WriteLine($"Posição 2: {lista.ObterPorPosição(2)} valor: {lista.ObterPorPosição(2)?.Valor}");
        
    }
}