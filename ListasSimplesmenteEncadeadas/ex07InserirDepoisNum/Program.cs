namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        // Inserir
        lista.InserirNoInicio(20);
        lista.InserirNoInicio(10);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(50);
        
        //inserir depois de
        bool inserido = lista.InserirDepoisDe(20, 25);
      

        // Mostrar lista antes
        Console.WriteLine("\nLista antes:");
        lista.Mostrar();
        
        // Buscar
        No? encontrado = lista.Buscar(30);

        Console.WriteLine(encontrado != null
            ? $"\nEncontrado: {encontrado.Valor}"
            : "\nNão encontrado!");

        // Contar
        Console.WriteLine($"Quantidade: {lista.Contar()}");
        Console.WriteLine($"Inserido: {inserido}");

       
    }   
}
