namespace Fsg.EstruturaDados;

public class ListaSimples
{
    public No? Inicio { get; set; }

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
            return;
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

    public bool InserirDepoisDe(int valorReferencia, int novoValor)
    {
        if (Inicio == null)
        {
            return false;
        }

        No? atual = Inicio;

        while (atual != null && atual.Valor != valorReferencia)
        {
            atual = atual.Proximo;
        }

        if (atual != null)
        {
            No novoNo = new No();
            novoNo.Valor = novoValor;
            novoNo.Proximo = atual.Proximo;
            atual.Proximo = novoNo;

            return true;
        }

        return false;
    }

    public No? ObterPorPosicao(int posicao)
    {
        if (posicao < 0)
        {
            return null;
        }

        int contador = 0;
        No? atual = Inicio;

        while (atual != null)
        {
            if (contador == posicao)
            {
                return atual;
            }

            atual = atual.Proximo;
            contador++;
        }

        return null;
    }

    public void Inverter()
    {
        No? anterior = null;
        No? atual = Inicio;

        while (atual != null)
        {
            No? proximo = atual.Proximo;
            atual.Proximo = anterior;
            anterior = atual;
            atual = proximo;
        }

        Inicio = anterior;
    }

    public void Listar()
    {
        No? atual = Inicio;

        while (atual != null)
        {
            Console.WriteLine($"* {atual.Valor}");
            atual = atual.Proximo;
        }
    }
}
