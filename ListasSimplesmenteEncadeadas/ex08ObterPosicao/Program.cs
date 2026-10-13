namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        ListaSimples lista = new ListaSimples();

        //inserir
        lista.InserirNoInicio(20);
        lista.InserirNoInicio(10);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(50);
        
        Console.WriteLine("\nLista antes:");
        lista.Mostrar();

        // Buscar
        No? encontrado = lista.Buscar(30);

        Console.WriteLine(encontrado != null
            ? $"\nEncontrado: {encontrado.Valor}"
            : "\nNão encontrado!");
        
        //contar
        Console.WriteLine($"Quantidade: {lista.Contar()}");
        
        No? posicao = lista.ObterPorPosicao(2);

        Console.WriteLine(posicao != null
            ? $"Posição 2: {lista.ObterPorPosicao(2)} Valor da Posição: {posicao.Valor}"
            : "Posição inválida!");
    }
    
    /* explique por que essa operação é diferente do acesso vetor[2].
     
     O acesso vetor[2] é diferente porque o vetor permite acessar diretamente o
     elemento da posição 2, enquanto na lista encadeada é necessário percorrer os nós desde o início até chegar à posição desejada.
     
    */
}