namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();
        
        lista.InserirNoInicio(5);
        lista.InserirNoFinal(10);
        lista.InserirNoInicio(2);
        lista.InserirNoFinal(20);
        lista.InserirNoFinal(50);
        
        lista.Remover(10);
        lista.RemoverDoInicio();
        
        No? encontrado;

        encontrado = lista.Buscar(10);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(20);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(40);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(50);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");
        
        lista.Mostrar();
        Console.WriteLine($"Quantidade: {lista.Contar()}");
        
    }
}