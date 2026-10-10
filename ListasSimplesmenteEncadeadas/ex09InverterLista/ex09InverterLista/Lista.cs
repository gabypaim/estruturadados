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

    public void Mostrar()
    {
        No? atual = Inicio; //começamos no inicio

        while (atual != null) //enquanto o atual não for nulo ele escreve o valor atual e vai para o proximo
        {
            Console.WriteLine(atual.Valor);
            atual = atual.Proximo;
        }
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
        
        //atual começa no inicio
        No atual = Inicio;
        
        //enquanto o proximo nó não for vazio o atual percorre
        while (atual.Proximo != null)
        {
            atual = atual.Proximo;
        }
        //coloca o nó no proxima que esta vazio
        atual.Proximo = novoNo;
        
    }

}
