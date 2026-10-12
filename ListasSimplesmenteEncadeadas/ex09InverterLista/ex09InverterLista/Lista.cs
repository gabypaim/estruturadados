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
        if (Inicio == null) //inicio for nulo
        {
            return null; //retorna nulo e acaba
        }

        No? atual = Inicio; //começa

        while (atual != null) // enquanto atual for diferente de nulo
        {
            if (atual.Valor == valor) // se valor atual for igual o valor buscado
            {
                return atual; // retorna o valor
            }
            atual = atual.Proximo; // passa para o proximo
        }
        return null; // retorna nulo se não encontrar
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

    public bool InserirDepoisDe(int valorReferencia, int novoValor)
    {
        
        if (Inicio == null) // inicio for vazio
        {
            return false; //retorna falso e acaba o metodo
        }
        
        No? atual = Inicio; //começa

        while (atual != null && atual.Valor != valorReferencia) //enquanto o atual n for nulo e atual for diferente da ref
        {
            atual = atual.Proximo; // passa para o proximo
        }

        if (atual != null) // se o atual for diff de nulo
        {
            No novoNo = new No(); // cria o no e add o valor
            novoNo.Valor = novoValor;
            
            novoNo.Proximo = atual.Proximo; // o proximo do novoNo é o proximo do atual
            atual.Proximo = novoNo; // o atual agora fica antes do novoNo
            
            return true; // retorna true
        }

        return false; // retorna false se não encontrar
    }

    public No ObterPorPosição(int posicao)
    {
        if (posicao < 0) // se posicao for negativa 
        {
            return null; // retorna nulo 
        }
        
        int contador = 0; // contador 0
        No? atual = Inicio; // começa
    
        while (atual != null) // atual não ultrapassar a lista
        {
            if (contador == posicao) // contador encontrar a posição
            {
                return atual; //retorna o no completo
            }
            
            atual = atual.Proximo; // passa pro proximo
            contador++; // contador +1
        }

        return null;  // retorna nuolo
    }

    public void Inverter()
    {
        // 10, 20 , 30 , 40, 50 , null
        No? anterior = null; 
        No? atual = Inicio; //atual = 10

        while (atual != null)
        {                 //10.20
            No? proximo = atual.Proximo; //proximo20
            atual.Proximo = anterior; // 10 apontar-> null
            
            anterior = atual; //anterior = 10
            atual = proximo; // 20 e repete enquanto não acabar a lista, que bomba é essa meu deus
        }
        
        Inicio = anterior; // agora o inicio é esse
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
