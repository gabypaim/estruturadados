namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();

        // Inserir cinco valores
        lista.InserirNoFinal(10);
        lista.InserirNoFinal(20);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(40);
        lista.InserirNoFinal(50);

        // Listar a estrutura
        Console.WriteLine("Lista inicial:");
        lista.Listar();

        // Buscar um valor
        No? encontrado = lista.Buscar(30);

        Console.WriteLine(encontrado != null
            ? $"Encontrado: {encontrado.Valor}"
            : "Não encontrado!");

        // Remover um valor intermediário
        lista.Remover(30);

        // Inserir depois de um nó existente
        lista.InserirDepoisDe(20, 25);

        // Consultar uma posição
        No? posicao = lista.ObterPorPosicao(2);

        Console.WriteLine(posicao != null
            ? $"Valor da posição 2: {posicao.Valor}"
            : "Posição inválida!");

        // Inverter a lista
        lista.Inverter();

        // Listar o resultado final
        Console.WriteLine("\nLista final:");
        lista.Listar();

          
        // No vetor, o acesso por posição é mais rápido.
        // A lista pode crescer sem precisar definir um tamanho fixo.
        // Na lista, inserir e remover no início é mais fácil, pois basta mudar o Inicio.
          
    }
}
