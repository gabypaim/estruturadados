namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        lista.InseriorNoInicio(20);
        lista.InseriorNoInicio(10);
        lista.InserirNoFinal(30);
        
        lista.Mostrar();
        Console.WriteLine($"Quantidade de nós: {lista.Contar()}");
    }
}
