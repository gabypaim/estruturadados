namespace Fsg.EstruturaDados;
class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        lista.InserirNoFinal(10);
        lista.InserirNoFinal(20);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(40);

        No? atual = lista.Inicio;

        while (atual != null)
        {
            Console.WriteLine(atual.Valor);
            atual = atual.Proximo;
        }
    }
}
