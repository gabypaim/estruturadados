namespace Fsg.EstruturaDados;

public class ListaSimples
{
    public No? Inicio { get; set; }

    public void InserirNoFinal(int valor)
    {
        No novoNo = new No();
        novoNo.Valor = valor;
        novoNo.Proximo = null;

        if (Inicio == null)
        {
            Inicio = novoNo;
            return;
        }

        No atual = Inicio;

        while (atual.Proximo != null)
        {
            atual = atual.Proximo;
        }

        atual.Proximo = novoNo;
    }

    public static ListaSimples Mesclar(ListaSimples a, ListaSimples b)
    {
        ListaSimples resultado = new ListaSimples();

        No? atualA = a.Inicio;
        No? atualB = b.Inicio;
        No? ultimo = null;

        while (atualA != null || atualB != null)
        {
            int valor;

            if (atualB == null ||
                (atualA != null && atualA.Valor <= atualB.Valor))
            {
                valor = atualA.Valor;
                atualA = atualA.Proximo;
            }
            else
            {
                valor = atualB.Valor;
                atualB = atualB.Proximo;
            }

            No novoNo = new No();
            novoNo.Valor = valor;
            novoNo.Proximo = null;

            if (resultado.Inicio == null)
            {
                resultado.Inicio = novoNo;
            }
            else
            {
                ultimo!.Proximo = novoNo;
            }

            ultimo = novoNo;
        }

        return resultado;
    }

    public void Exibir()
    {
        No? atual = Inicio;

        while (atual != null)
        {
            Console.Write(atual.Valor + " ");
            atual = atual.Proximo;
        }

        Console.WriteLine();
    }
}

/* A complexidade da solução é O(n + m), pois percorremos cada uma das duas listas apenas uma vez, comparando seus elementos e inserindo-os na nova lista.

Se utilizássemos InserirNoFinal para cada elemento, a complexidade seria O((n + m)²), pois esse método percorre a lista desde o início para encontrar o último nó a cada inserção.

    Por isso, manter uma referência para o último nó torna a operação mais eficiente, evitando percorrer a lista resultante repetidamente */