namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();

        lista.InserirNoInicio(20);
        lista.InserirNoInicio(10);
        lista.InserirNoFinal(30);
        bool removido = lista.RemoverDoInicio();
        No? encontrado = lista.Buscar(10);
        int quantidade = lista.Contar();

        //saída
        Console.WriteLine(encontrado?.Valor);
        Console.WriteLine($"quantidade: {quantidade}");
        Console.WriteLine($"Removido: {removido}");
        lista.Mostrar();
    }
}