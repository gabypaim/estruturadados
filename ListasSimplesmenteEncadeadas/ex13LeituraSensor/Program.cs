using Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        lista.InserirNoFinal(22);
        lista.InserirNoFinal(23);
        lista.InserirNoFinal(22);
        lista.InserirNoFinal(25);
        lista.InserirNoFinal(23);
        lista.InserirNoFinal(23);
        lista.InserirNoFinal(26);

        lista.RemoverDuplicados();

        No? atual = lista.Inicio;

        while (atual != null)
        {
            Console.Write(atual.Valor + " ");
            atual = atual.Proximo;
        }
    }
}

//A complexidade é O(n²), porque utilizamos dois laços de repetição.
//Para cada nó, percorremos os nós seguintes procurando valores repetidos. Por isso, não é O(n), pois não percorremos a lista apenas uma vez.