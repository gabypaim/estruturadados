namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        lista.InserirNoInicio(30);
        lista.InserirNoInicio(20);
        lista.InserirNoInicio(10);

        No? atual = lista.Inicio;

        while (atual != null)
        {
            Console.WriteLine(atual.Valor);
            atual = atual.Proximo;
        }
    }
}
