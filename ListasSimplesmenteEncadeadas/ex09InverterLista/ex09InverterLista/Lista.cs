namespace Fsg.EstruturaDados;

public class Lista
{
    public No? Inicio {get; set;}

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

    public No Buscar(int valor)
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
    public bool RemoverDoInicio()
    {
        if (Inicio == null) //se a lista for vazia o metodo retorna false
        {
            return false;
        }
        
        Inicio = Inicio.Proximo; //inicio vai para o proximo mesmo se for null
        return true; //retorna verdadeiro
    }

    public void Remover(int valor)
    {
        if (Inicio == null) // lista vazia acaba
        {
            return;
        }

        if (Inicio.Valor == valor) //valor está no inicio 
        {
            Inicio = Inicio.Proximo; //inicio agora vai ser o proximo 
            return; // acaba o metodo pq ja removeu 
        }
        
        No? anterior = null;
        No? atual =  Inicio;

        while (atual != null && atual.Valor != valor) // enquanto atual não for vazio e atual n for o valor 
        {
            anterior = atual; // guarda o nó atual como anterior
            atual = atual.Proximo; // avança pro proximo nó
        }

        if (atual == null)
        {
            return; // se o atual percorre a lista inteira e não encontra ela acaba recebendo null e então acaba
        }
        
        anterior!.Proximo = atual.Proximo; //anterior não vai apontar para o proximo ele vai apontar para o proximo do atual (vai pular o atual e ir direto pro proximo)
    }

    public void InserirDepoisDe(int valor, int referencia)
    {
        if (Inicio == null)
        {
            return;
        }
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
