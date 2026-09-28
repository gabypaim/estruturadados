namespace Fsg.EstruturaDados;


public class Lista
{
    public No? Inicio {  get; set; }

    public void InserirNoInicio(int valor)
    {
        No novoNo = new No();

        novoNo.Valor = valor;
        novoNo.Proximo = Inicio;

        Inicio = novoNo;
    }

    public void InserirNoFinal(int valor)
    {
        No novoNo = new No();

        novoNo.Valor = valor;
        novoNo.Proximo = null;

        while (Inicio == null)
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

    public int Contar()
    {
        No? atual = Inicio;
        int quantidade = 0;

        while (atual != null)
        {
            quantidade++;
            atual = atual.Proximo;
        }

        return quantidade;
    }

    public void Mostrar()
    {
        No? atual = Inicio;

        while (atual != null)
        {
            Console.WriteLine(atual.Valor);
            atual = atual.Proximo;
        }
    }
    public No? Buscar(int valor)
    {
        No? atual = Inicio;

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
        if (Inicio == null)
        {
            return false;
        }
         
        Inicio = Inicio.Proximo;

        return true;
    }

    public void Remover(int valor)
    {
        if (Inicio == null)
        {
            return;
        }

        if (Inicio.Valor == valor)
        {
            Inicio = Inicio.Proximo;
        }

        No? anterior = null;
        No? atual = Inicio;

        while (atual != null && atual.Valor != valor)
        {
            anterior = atual;
            atual = atual.Proximo;
        }

        if (atual == null)
        {
            return;
        }

        anterior!.Proximo = atual.Proximo;
    }

}

