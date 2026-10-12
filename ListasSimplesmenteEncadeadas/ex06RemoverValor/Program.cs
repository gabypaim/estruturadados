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

        Console.WriteLine("Lista antes:");
        lista.Mostrar();
        
        //buscar
        No? encontrado = lista.Buscar(30);
        Console.WriteLine(encontrado != null
            ? $"\nEncontrado: {encontrado.Valor}"
            :"Não encontrado!\n"
            );

        Console.WriteLine($"Quantidade: {lista.Contar()}");

        
        lista.Remover(30);
        
        Console.WriteLine("\nLista agora:");
        lista.Mostrar();
        Console.WriteLine($"Quantidade: {lista.Contar()}");

    }
}