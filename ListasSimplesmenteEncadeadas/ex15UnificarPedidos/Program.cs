namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples a = new ListaSimples();
        a.InserirNoFinal(3);
        a.InserirNoFinal(8);
        a.InserirNoFinal(12);
        a.InserirNoFinal(20);

        ListaSimples b = new ListaSimples();
        b.InserirNoFinal(5);
        b.InserirNoFinal(8);
        b.InserirNoFinal(15);

        Console.WriteLine("Lista A:");
        a.Exibir();

        Console.WriteLine("Lista B:");
        b.Exibir();

        ListaSimples resultado = ListaSimples.Mesclar(a, b);

        Console.WriteLine("Lista mesclada:");
        resultado.Exibir();
    }
}