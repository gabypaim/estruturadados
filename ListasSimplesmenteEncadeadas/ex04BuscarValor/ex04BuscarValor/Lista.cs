namespace Fsg.EstruturaDados;

public class Lista
{
    No? Inicio { get; set; }
    
    public void InserirNoInicio(int valor)
    {
        No novoNo = new No(); //cria um no mas está solto ainda
        novoNo.Valor = valor; //atribui o valor dado ao atributo Valor
        novoNo.Proximo = Inicio; // O novo no fica antes do Inicio
        
        Inicio = novoNo; //Inicio agora é o novoNo

    }
    public void InserirNoFinal(int valor)
    {
        //cria o no
        No novoNo = new No();
        novoNo.Valor = valor;
        novoNo.Proximo = null;
        
        //se a lista for vazia
        if (Inicio == null)
        {
            Inicio = novoNo; //o novoNo é o primeiro e unico
            return;
        }
        
        No atual = Inicio;  //atual começa no inicio
        
        while (atual.Proximo != null)  //enquanto o proximo nó não for vazio o atual percorre

        {
            atual = atual.Proximo;
        }
        atual.Proximo = novoNo;  //coloca o nó no proxima que esta vazio
    }
    
    public int Contar()
    {
        int quantidade = 0;
        No? atual = Inicio;

        while (atual != null)
        {
            quantidade++;
            atual = atual.Proximo;
        }
        return quantidade;
    }
    public No? Buscar(int valor)
    {
        if (Inicio == null)
        {
            return null;
        }

        No atual = Inicio;

        while (atual != null)
        {
            if (atual.Valor == valor)
            {
                return atual;
            }
            atual = atual.Proximo;
        }
        return null;
    }
    
    public void Mostrar()
    {
        No? atual = Inicio; //começamos no inicio

        while (atual != null) //enquanto o atual não for nulo ele escreve o valor atual e vai para o proximo
        {
            Console.WriteLine($"* {atual.Valor}");
            atual = atual.Proximo;
        }
    }
}