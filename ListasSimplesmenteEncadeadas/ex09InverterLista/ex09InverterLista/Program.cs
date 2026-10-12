namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();
        
        //inserir
        lista.InserirNoInicio(20);
        lista.InserirNoFinal(10);
        lista.InserirNoInicio(2);
        lista.InserirNoFinal(30);
        lista.InserirNoFinal(50);
        
        Console.WriteLine($"Lista antes");
        lista.Mostrar();
        
        //remover
        lista.Remover(10);
        lista.RemoverDoInicio();
        
        //inserir depois 
        lista.InserirDepoisDe(20,25);

        //buscar
        No? encontrado = lista.Buscar(30);

        Console.WriteLine(encontrado != null
            ? $"\nEncontrado: {encontrado.Valor}"
            : "\nNão encontrado!");
        
        //contar
        Console.WriteLine($"Quantidade: {lista.Contar()}");
        //obter Posição
        Console.WriteLine($"Posição 2: {lista.ObterPorPosicao(2)} valor: {lista.ObterPorPosicao(2)?.Valor}");

       
        Console.Write("\nLista agora:\n");
        lista.Inverter();
        lista.Mostrar();
        
        //contar
        Console.WriteLine($"Quantidade: {lista.Contar()}");
        //obter Posição
        Console.WriteLine($"Posição 2: {lista.ObterPorPosicao(2)} valor: {lista.ObterPorPosicao(2)?.Valor}");
    }
}