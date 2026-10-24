namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        FilaDeAtendimento fila = new FilaDeAtendimento();

        fila.EmitirSenha(101);
        fila.EmitirSenha(102);
        fila.EmitirSenha(103);
        
        Console.WriteLine($"Chamando: {fila.ChamarProxima()}");
        Console.WriteLine($"Chamando: {fila.ChamarProxima()}");
        
        fila.EmitirSenha(104);
        
        Console.WriteLine("Senhas Aguardandoo:");
        fila.MostrarAguardando();
        
        Console.WriteLine(($"Quantidade aguardando: {fila.QuantidadeAguardando()}"));

        //Reflexão: A operação InserirNoFinal() ficaria O(1), pois, se a lista guardasse uma referência para o último
        //nó , não seria necessário percorrer todos os nós para encontrar onde inserir o novo elemento.
    }
}