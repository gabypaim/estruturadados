using Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        lista.InserirOrdenadoDecrescente(150);
        lista.InserirOrdenadoDecrescente(300);
        lista.InserirOrdenadoDecrescente(90);
        lista.InserirOrdenadoDecrescente(300);
        lista.InserirOrdenadoDecrescente(200);

        Console.WriteLine("Lista completa:");
        lista.ExibirTop(5);

        Console.WriteLine("Top 3:");
        lista.ExibirTop(3);
    }
}

//No vetor, é necessário deslocar os elementos para abrir espaço para a nova pontuação na posição correta.
//Já na lista encadeada, precisamos percorrer os nós para encontrar a posição, mas basta alterar as referências para inserir o novo elemento, sem deslocar os demais.