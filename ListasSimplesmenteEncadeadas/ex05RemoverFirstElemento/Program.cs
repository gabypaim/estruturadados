namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();

        lista.InserirNoInicio(20);
        lista.InserirNoInicio(10);
        lista.InserirNoFinal(30);
        lista.InserirNoInicio(5);
        
        Console.WriteLine("Lista antes:");
        lista.Mostrar();
        
        //remover
        bool removido = lista.RemoverDoInicio();
        
        //buscar
        No? encontrado = lista.Buscar(10);

        Console.WriteLine(encontrado != null
            ? $"\nEncontrado: {encontrado.Valor}"
            : "Não encontrado!\n");
        
        //saída
        Console.WriteLine($"quantidade: {lista.Contar()}");
        Console.WriteLine($"Removido: {removido}");
        
        Console.WriteLine("\nLista agora:");
        lista.Mostrar();
    }
}