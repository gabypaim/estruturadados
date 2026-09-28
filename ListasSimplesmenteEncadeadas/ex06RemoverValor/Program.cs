namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();

        lista.InserirNoInicio(20);
        lista.InserirNoInicio(10);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(50);

        Console.WriteLine("\nLista antes:");
        lista.Mostrar();

        No? encontrado = lista.Buscar(30);
        int quantidade = lista.Contar();

        Console.WriteLine($"Valor encontrado: {encontrado?.Valor}");
        Console.WriteLine($"Quantidade: {quantidade}");

        lista.Remover(30);

        Console.WriteLine("\nLista agora:");
        lista.Mostrar();

        quantidade = lista.Contar();
        encontrado = lista.Buscar(30);

        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Valor encontrado: {encontrado?.Valor}");
    }
}