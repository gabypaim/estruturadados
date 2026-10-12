namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();

        lista.InserirNoFinal(30);
        lista.InserirNoInicio(20);
        lista.InserirNoInicio(10);
        lista.Mostrar();
        
        No? encontrado;
        
        Console.WriteLine($"Quantidade: {lista.Contar()}");
        
        encontrado = lista.Buscar(10);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(20);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(40);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");

        encontrado = lista.Buscar(50);
        Console.WriteLine(encontrado != null ? encontrado.Valor : "Valor não encontrado");
        
        Console.WriteLine(encontrado?.Valor);
    }
}