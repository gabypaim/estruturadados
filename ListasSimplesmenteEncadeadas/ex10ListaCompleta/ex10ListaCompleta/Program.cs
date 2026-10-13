namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        // inserir
        lista.InserirNoInicio(20);
        lista.InserirNoFinal(10);
        lista.InserirNoInicio(2);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(50);

        Console.WriteLine("Lista antes:");
        lista.Listar();

        // remover
        lista.Remover(10);
        lista.RemoverDoInicio();

        // inserir depois
        lista.InserirDepoisDe(20, 25);

        // buscar
        No? encontrado = lista.Buscar(30);

        Console.WriteLine(encontrado != null
            ? $"\nEncontrado: {encontrado.Valor}"
            : "\nNão encontrado!");

        // contar
        Console.WriteLine($"Quantidade: {lista.Contar()}");

        // obter posição
        No? posicao = lista.ObterPorPosicao(2);

        Console.WriteLine(posicao != null
            ? $"\nPosição 2: {posicao.Valor}"
            : "\nPosição inválida!");

        // inverter
        lista.Inverter();

        Console.WriteLine("\nLista depois de inverter:");
        lista.Listar();

        // comparação com vetor:
        // No vetor, acessar uma posição é mais rápido.
        // Na lista, precisamos percorrer os nós até chegar na posição.
        // O vetor tem tamanho definido, enquanto a lista pode crescer.
        // Inserir e remover no início da lista é simples,
        // pois basta alterar o Inicio.
    }
}