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
        int quantidade = lista.Contar();
        No? encontrado = lista.Buscar(10);

        Console.WriteLine(encontrado?.Valor);
        Console.WriteLine($"quantidade: {quantidade}");
    }
}