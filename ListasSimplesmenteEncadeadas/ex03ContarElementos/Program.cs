namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        lista.InserirNoInicio(20);
        lista.InserirNoInicio(10);
        lista.InserirNoFinal(30);
        
        lista.Mostrar();
        Console.WriteLine($"Quantidade de nós: {lista.Contar()}");
    }
}
